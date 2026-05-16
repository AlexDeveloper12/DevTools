### README.md

This project is a comprehensive collection of developer tools built using **Blazor WebAssembly** and **.NET 10**. It provides a range of utility applications designed to help developers with everyday tasks directly in the browser.

### Features

#### 1. Password Generator
A highly customizable tool for generating secure passwords.
- **Custom Length**: Use a slider to set the desired password length (1-20 characters).
- **Complexity Options**: Toggle Uppercase, Lowercase, Numbers, and Symbols.
- **Strength Meter**: Real-time visual feedback on the strength of your generated password (Weak, Average, Strong).
- **Validation**: Ensures at least one character type is selected before generation.

#### 2. GUID Generator
Quickly generate unique identifiers.
- **Single GUID Generation**: Create a new GUID with a single click.
- **Copy to Clipboard**: Easily copy the generated GUID for use in your code or database.

#### 3. JSON Prettifier
Format and validate JSON strings.
- **Indentation**: Automatically formats messy or minified JSON into a readable, indented structure.
- **Validation**: Provides error messages if the input is not a valid JSON format.

#### 4. Character Counter
Simple utility for counting characters in real-time.
- **Live Updates**: Counts characters as you type or paste text into the editor.

### Tech Stack
- **Framework**: ASP.NET Core Blazor WebAssembly
- **Language**: C# 14.0
- **Runtime**: .NET 10.0
- **Styling**: Bootstrap 5 with custom CSS modules

### Project Structure
- `DevTools.UI`: Main project containing the Blazor application.
- `DevTools.UI.Client`: Client-side logic and components.
- `Components`: Reusable UI components like `ListItemCheckbox`, `PasswordInput`, and `GenericAlert`.
- `Pages`: Individual tool pages (e.g., `PasswordGenerator.razor`, `GUIDGenerator.razor`).

### Getting Started

#### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- An IDE such as [JetBrains Rider](https://www.jetbrains.com/rider/) or [Visual Studio 2022](https://visualstudio.microsoft.com/)

#### Running the Application
1. Clone the repository to your local machine.
2. Open the solution file `DevTools.sln`.
3. Restore the NuGet packages.
4. Run the project (`dotnet run` or via your IDE).
5. Navigate to `https://localhost:xxxx` to use the tools.

### License
This project is open-source and available for developer use
