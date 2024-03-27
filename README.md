
# Resting: ASP.NET Core RESTful API for Order Management

## Description

This project is a RESTful API developed using ASP.NET Core, designed to manage orders within an e-commerce or inventory management system. It utilizes Entity Framework Core for data access, adhering to the Repository pattern to abstract the logic of accessing data sources. The API supports basic CRUD (Create, Read, Update, Delete) operations for orders.

## Features

- RESTful API endpoints to manage orders.
- CRUD operations for order entities.
- Repository pattern implementation for data access abstraction.
- Dependency Injection for managing repositories.
- Entity Framework Core as the ORM for data manipulation.

## Technologies

- .NET 5/6
- ASP.NET Core
- Entity Framework Core
- SQL Server

## Getting Started

### Prerequisites

- .NET 5/6 SDK
- SQL Server (LocalDB, Express, or higher)
- Visual Studio or Visual Studio Code

### Installation

1. Clone the repository:
   ```sh
   git clone https://github.com/jaximuss/Resting.git
   ```

2. Navigate to the project directory:
   ```sh
   cd path/to/project
   ```

3. Restore the .NET packages:
   ```sh
   dotnet restore
   ```

4. Update the database with the latest migration:
   ```sh
   dotnet ef database update
   ```

### Configuration

- Ensure your `appsettings.json` file contains the correct connection string to your SQL Server instance:
   ```json
   "ConnectionStrings": {
       "MyAppContext": "Server=(localdb)\\mssqllocaldb;Database=MyAppDb;Trusted_Connection=True;"
   }
   ```

## Usage

To run the application, use the following command:

```sh
dotnet run
```

The API will be available at `http://localhost:5000` by default.

### API Endpoints

- **GET** `/api/orders` - Retrieves a list of all orders.
- **GET** `/api/orders/{id}` - Retrieves a specific order by ID.
- **POST** `/api/orders` - Creates a new order.
- **DELETE** `/api/orders/{id}` - Deletes an order by ID.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open issues to suggest improvements or add new features.

## License

This project is licensed under the MIT License - see the LICENSE file for details.
```
