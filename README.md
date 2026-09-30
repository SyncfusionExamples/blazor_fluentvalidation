# Blazor FluentValidation with Syncfusion Components

## Overview

This sample demonstrates how to integrate FluentValidation with Syncfusion Blazor form components in a hosted Blazor WebAssembly application. The application captures employee information through a form and validates user input using FluentValidation instead of the built-in DataAnnotations validation framework.

The sample shows how validation rules can be centralized in dedicated validator classes, resulting in cleaner models, improved maintainability, and more flexible validation logic. It also demonstrates how FluentValidation can participate in the Blazor form validation lifecycle while working seamlessly with Syncfusion input components.

## Key Features

- Integrates FluentValidation with Blazor `EditForm` using the custom `FluentValidator<TValidator>` component.
- Demonstrates validation of an `Employee` model through an `EmployeeValidator` class.
- Uses Syncfusion Blazor TextBox components (`SfTextBox`) for employee name, email, address, and postal code input.
- Uses Syncfusion Blazor DatePicker (`SfDatePicker`) for capturing employee date of birth.
- Uses Syncfusion Blazor NumericTextBox (`SfNumericTextBox`) for entering total years of experience.
- Uses Syncfusion Blazor DropDownList (`SfDropDownList`) for gender selection with two-way data binding.
- Uses Syncfusion Blazor ComboBox (`SfComboBox`) for country selection.
- Uses Syncfusion Blazor DropDownList with `Query` and `WhereFilter` objects to implement dependent city filtering based on the selected country.
- Handles country selection changes through the `ValueChange` event and dynamically updates available city values.
- Demonstrates binding and validation of nested model properties through the `PermanentAddress` object.
- Displays aggregated validation errors using the Blazor `ValidationSummary` component.
- Executes business logic through the `OnValidSubmit` event after successful validation.
- Implements dynamic enabling and disabling of city selection based on country availability.
- Includes a hosted Blazor WebAssembly architecture with shared models and server-side API endpoints.
- Provides a sample weather forecast page that demonstrates HTTP data retrieval using `HttpClient` and JSON deserialization.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the `SyncFluentValidation.sln` solution file.
3. Restore all NuGet packages.
4. Build the solution.
5. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Clone or download this repository.
2. Open the repository folder in Visual Studio Code.
3. Open a terminal window.
4. Navigate to the repository root folder.
5. Execute the following commands:

```bash
dotnet restore
dotnet run
```

6. Open the application URL displayed in the terminal output.

## Project Structure

`SyncFluentValidation.sln` - Solution file containing the hosted Blazor WebAssembly FluentValidation sample.

`Client/Pages/Index.razor` - Main employee registration form demonstrating FluentValidation integration with Syncfusion Blazor input components including TextBox, DatePicker, NumericTextBox, ComboBox, DropDownList, and Button controls.

`Client/Pages/FetchData.razor` - Sample page that retrieves weather forecast data from the server using `HttpClient` and displays the results in a tabular layout.

`Client/Model/Employee.cs` - Contains the `Employee` model, nested `PermanentAddress` model, and country/city data source classes used by the form components.

`Client/Model/EmployeeValidator.cs` - Contains the `EmployeeValidator` and `AddressValidator` FluentValidation classes that define validation rules for employee and address information.

`Client/Model/FluentValidator.cs` - Custom Blazor validation component that integrates FluentValidation with the Blazor `EditContext`, handles validation events, and displays validation messages.

`Server/Controllers/WeatherForecastController.cs` - ASP.NET Core Web API controller that generates and returns sample weather forecast data.

`Shared/WeatherForecast.cs` - Shared weather forecast model used by both the client and server projects.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Blazor FAQ: https://www.syncfusion.com/faq/blazor/forms-and-validation

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.