# .NET MAUI Localization Demo

This is a sample .NET MAUI project that showcases how to implement localization in a cross-platform application using resource files.

## Prerequisites

- .NET MAUI SDK installed (compatible with your operating system)
- Visual Studio 2022 or Visual Studio Code (with .NET MAUI extension)
- Basic knowledge of C# and XAML

## Getting Started

1. Clone or download this repository to your local machine.

2. Open the solution in Visual Studio 2022 or Visual Studio Code.

3. Build the solution to restore NuGet packages and ensure everything is set up correctly.

4. Navigate to the `App.xaml.cs` file in the shared project (`MyApp`) and locate the `OnStart` method.

5. Inside the `OnStart` method, you will find a line of code that sets the current app culture. By default, it's set to `en-US`.

    ```csharp
    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
    ```

   Modify this line to the desired culture code to test different localizations. For example, to switch to German, change it to:

    ```csharp
    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-DE");
    ```

6. Run the application on your desired target platform (Android, iOS, Windows).

7. The app will now display the localized content based on the selected culture. You can explore the different pages in the application to see the localization in action.

## Adding New Localizations

To add a new localization, follow these steps:

1. In the shared project (`MyApp`), navigate to the `Resources` folder.

2. Create a new resource file for the desired language. For example, to add French localization, create a file named `AppResources.fr.resx`.

3. Open the newly created resource file and add the localized strings and their corresponding values.

4. Build the solution to generate the necessary code-behind files.

5. In the `App.xaml.cs` file, modify the `OnStart` method to set the desired culture for the new localization.

    ```csharp
    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-FR");
    ```

6. Run the application, and it should now display the content in the newly added localization.

## Contributing

Contributions are welcome! If you have any suggestions or improvements for this project, please feel free to open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

## Acknowledgments

This project was inspired by the official .NET MAUI documentation and the localization features provided by .NET.

