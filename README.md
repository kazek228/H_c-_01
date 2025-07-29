# ConsoleApp

A simple C# console application built with .NET 9.0.

## Description

This is a basic console application that demonstrates the fundamentals of C# programming. It serves as a starting point for building more complex console-based applications.

## Prerequisites

- .NET 9.0 SDK or later
- Visual Studio Code (recommended)
- C# extension for VS Code

## Getting Started

### Building the Application

To build the application, run:

```bash
dotnet build ConsoleApp.csproj
```

### Running the Application

To run the application, use:

```bash
dotnet run --project ConsoleApp.csproj
```

### Development

This project is configured for development in Visual Studio Code with:
- C# extension support
- IntelliSense and debugging capabilities
- Custom Copilot instructions in `.github/copilot-instructions.md`

## Project Structure

```
.
├── .github/
│   └── copilot-instructions.md    # Custom Copilot instructions
├── Program.cs                     # Main application entry point
├── ConsoleApp.csproj             # Project configuration
└── README.md                     # This file
```

## Features

- Simple "Hello, World!" output
- .NET 9.0 targeting
- Nullable reference types enabled
- Implicit using statements enabled

## Next Steps

You can extend this application by:
- Adding command-line argument parsing
- Implementing user input handling
- Adding configuration file support
- Creating additional classes and methods
- Adding unit tests

## Contributing

Feel free to modify and extend this application according to your needs.
