# SOLID Principles in .NET 9

This repository demonstrates the five SOLID principles of object-oriented design using C# and .NET 9. Each principle is illustrated with both a "bad" (violating) and a "good" (compliant) example, making it easy to understand the motivation and benefits of applying SOLID in real-world code.

## Principles Covered

- **Single Responsibility Principle (SRP)**
  - Each class should have one, and only one, reason to change.
  - See: `SingleResponsibilityPrinciple/SRP_Bad_Example.cs` and `SingleResponsibilityPrinciple/SRP_Good_Example.cs`

- **Open/Closed Principle (OCP)**
  - Software entities should be open for extension, but closed for modification.
  - See: `OpenClosePrinciple/OCP_Bad_Example.cs` and `OpenClosePrinciple/OCP_Good_Example.cs`

- **Liskov Substitution Principle (LSP)**
  - Subtypes must be substitutable for their base types without altering the correctness of the program.
  - See: `LiskvSubstitutePrinciple/LSP_Bad_Example.cs` and `LiskvSubstitutePrinciple/LSP_Good_Example.cs`

- **Interface Segregation Principle (ISP)**
  - Clients should not be forced to depend on interfaces they do not use.
  - See: `InterfaceSegregationPrinciple/ISP_Bad_Example.cs` and `InterfaceSegregationPrinciple/ISP_Good_Example.cs`

- **Dependency Inversion Principle (DIP)**
  - High-level modules should not depend on low-level modules; both should depend on abstractions.
  - See: `DependencyInversionPrinciple/DIP_Bad_Example.cs` and `DependencyInversionPrinciple/DIP_Good_Example.cs`

## Project Structure


## How to Run

1. **Requirements:** [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
2. Open the solution in Visual Studio 2022.
3. Set the desired example file as the startup object.
4. Run the project to see console output demonstrating each principle.

## Learning Resources

- [SOLID Principles - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#solid-principles)
- [SOLID Principles - Wikipedia](https://en.wikipedia.org/wiki/SOLID)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For questions, suggestions, or contributions, please contact:

Ather Husain - [@ather_techie](https://twitter.com/ather_techie) - ather.techie@gmail.com

Project Link: [solidprinciples](https://github.com/ather-techie/solidprinciples)

## Acknowledgments

- Inspired by Robert C. Martin ("Uncle Bob") and the original SOLID principles.
