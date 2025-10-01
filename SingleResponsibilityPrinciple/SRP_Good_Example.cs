namespace SolidPrinciples;

// SRP Good Example: Each class/interface has a single responsibility.

// 1. Data Parsing
public interface IUserDataParser
{
    User Parse(string userData);
}

public class UserDataParser : IUserDataParser
{
    public User Parse(string userData)
    {
        // Parsing logic
        Console.WriteLine("Parsing user data.");
        return new User();
    }
}

// 2. Data Validation
public interface IUserDataValidator
{
    bool Validate(User user);
}

public class UserDataValidator : IUserDataValidator
{
    public bool Validate(User user)
    {
        // Validation logic
        Console.WriteLine("Validating user.");
        return true;
    }
}

// 3. Data Persistence (Database)
public interface IUserRepository
{
    void Save(User user);
}

public class UserRepository : IUserRepository
{
    public void Save(User user)
    {
        // Database saving logic
        Console.WriteLine("Saving user to database.");
    }
}

// 4. Email Sending
public interface IEmailService
{
    void SendConfirmation(User user, string emailAddress);
}

public class EmailService : IEmailService
{
    public void SendConfirmation(User user, string emailAddress)
    {
        // Email sending logic
        Console.WriteLine($"Sending confirmation email to {emailAddress}.");
    }
}

// 5. Logging
public interface ILogger
{
    void Log(string message, string filePath);
}

public class Logger : ILogger
{
    public void Log(string message, string filePath)
    {
        // Logging logic
        Console.WriteLine($"Logging: {message} to {filePath}");
    }
}

// 6. User Processing Orchestrator
public class UserProcessor1
{
    // Uses dependency injection for each responsibility.
    private readonly IUserDataParser _parser;
    private readonly IUserDataValidator _validator;
    private readonly IUserRepository _repository;
    private readonly IEmailService _emailService;
    private readonly ILogger _logger;

    public UserProcessor1(IUserDataParser parser, IUserDataValidator validator, IUserRepository repository, IEmailService emailService, ILogger logger)
    {
        _parser = parser;
        _validator = validator;
        _repository = repository;
        _emailService = emailService;
        _logger = logger;
    }

    // Only coordinates the workflow, delegates responsibilities.
    public void ProcessUser(string userData, string logFilePath, string emailAddress)
    {
        var user = _parser.Parse(userData);

        if (!_validator.Validate(user))
        {
            _logger.Log("User data validation failed.", logFilePath);
            return;
        }

        _repository.Save(user);
        _emailService.SendConfirmation(user, emailAddress);
        _logger.Log("User processed successfully.", logFilePath);
    }
}

// User class
public class User { }
