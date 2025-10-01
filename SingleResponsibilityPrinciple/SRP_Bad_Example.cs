namespace SolidPrinciples;

// SRP Violation Example: This class does too much.
// It handles parsing, validation, persistence, emailing, and logging all in one place.
public class UserProcessor
{
    // This method violates SRP by handling multiple responsibilities.
    public void ProcessUser(string userData, string logFilePath, string emailAddress)
    {
        // 1. Parse user data
        var user = ParseUserData(userData);

        // 2. Validate user data
        if (!ValidateUser(user))
        {
            Log("User data validation failed.", logFilePath);
            return;
        }

        // 3. Save user to database
        SaveUserToDatabase(user);

        // 4. Send confirmation email
        SendConfirmationEmail(user, emailAddress);

        // 5. Log user processing success
        Log("User processed successfully.", logFilePath);
    }

    // Handles parsing (should be a separate responsibility)
    private User ParseUserData(string userData)
    {
        // Parsing logic here...
        Console.WriteLine("Parsing user data.");
        return new User(); // Simplified example
    }

    // Handles validation (should be a separate responsibility)
    private bool ValidateUser(User user)
    {
        // Validation logic here...
        Console.WriteLine("Validating user.");
        return true; // Simplified example
    }

    // Handles persistence (should be a separate responsibility)
    private void SaveUserToDatabase(User user)
    {
        // Database saving logic here...
        Console.WriteLine("Saving user to database.");
    }

    // Handles emailing (should be a separate responsibility)
    private void SendConfirmationEmail(User user, string emailAddress)
    {
        // Email sending logic here...
        Console.WriteLine($"Sending confirmation email to {emailAddress}.");
    }

    // Handles logging (should be a separate responsibility)
    private void Log(string message, string filePath)
    {
        // Logging logic here...
        Console.WriteLine($"Logging: {message} to {filePath}");
    }

    // Inner User class for simplicity.
    public class User { }
}
