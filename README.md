# Pie Shop Web Application

This repository contains a comprehensive web application for a Pie Shop built using ASP.NET Core and Entity Framework Core. The application allows users to browse a variety of pies, register and log in, and place orders. The project demonstrates the use of several key features of ASP.NET Core to create a robust, secure, and interactive web application.

## Features

- **Entity Framework Core Integration**: Utilizes Entity Framework Core for database operations, including migrations and seeding data.
- **Routing and Navigation**: Implements attribute routing and conventional routing to manage application navigation.
- **Dynamic Views**: Uses Razor views to display dynamic content to users.
- **Forms and Model Binding**: Leverages tag helpers and model binding to handle form inputs and user data.
- **Authentication and Authorization**: Implements ASP.NET Core Identity for user registration, login, and role-based access control.
- **Interactivity**: Incorporates JavaScript and jQuery for enhanced user interactions and AJAX functionality.
- **Testing**: Includes unit and integration tests to ensure the reliability and correctness of the application components.

## Getting Started

### Prerequisites

- .NET Core SDK
- SQL Server or another compatible database

### Installation

1. Clone the repository:

    ```sh
    git clone https://github.com/yourusername/pie-shop-web-application.git
    cd pie-shop-web-application
    ```

2. Configure the database connection string in `appsettings.json`:

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "YourDatabaseConnectionString"
      }
    }
    ```

3. Apply database migrations and seed data:

    ```sh
    dotnet ef database update
    ```

4. Run the application:

    ```sh
    dotnet run
    ```

### Usage

- Navigate to the home page to view the list of available pies.
- Register a new user account or log in with an existing account.
- Browse pies and place orders.

## Project Structure

- **Models**: Defines the data models and relationships.
- **Data**: Contains the DbContext and seed data.
- **Controllers**: Manages request handling and business logic.
- **Views**: Provides the UI using Razor views.
- **Services**: Implements business logic and application services.
- **Tests**: Contains unit and integration tests for the application.

## Contributing

Contributions are welcome! Please fork this repository and submit pull requests with any improvements or bug fixes.

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes (`git commit -m 'Add some feature'`)
4. Push to the branch (`git push origin feature/YourFeature`)
5. Open a pull request



## Acknowledgements

- Thanks to the ASP.NET Core and Entity Framework Core teams for their excellent frameworks and documentation.
- Inspired by various online tutorials and community contributions.
