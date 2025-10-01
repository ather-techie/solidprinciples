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

MIT License

Copyright (c) 2025 [Your Name]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Contact

For questions, suggestions, or contributions, please contact:

Ather Husain - [@ather_techie](https://twitter.com/ather_techie) - ather.techie@gmail.com

Project Link: [solidprinciples](https://github.com/ather-techie/solidprinciples)

## Acknowledgments

- Inspired by Robert C. Martin ("Uncle Bob") and the original SOLID principles.
