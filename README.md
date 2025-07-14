# Store Management WebAPI

A RESTful Web API built with ASP.NET Core 8.0 and LiteDB for managing store inventory items. This project demonstrates CRUD operations, dependency injection, and clean architecture principles. The purpose of this project is educational. In this project, I learned REST API Architecture, HTTP requests and proper communication between database and backend.

## Features

- **Full CRUD Operations**: Create, Read, Update, and Delete store items
- **RESTful API Design**: Standard HTTP methods and status codes
- **Lightweight Database**: Uses LiteDB for data persistence
- **Dependency Injection**: Implements service-oriented architecture
- **API Documentation**: Integrated Swagger/OpenAPI documentation
- **Clean Architecture**: Separation of concerns with controllers, services, and models

## Tech Stack

- **Framework**: ASP.NET Core 8.0
- **Database**: LiteDB (NoSQL embedded database)
- **Documentation**: Swagger/OpenAPI
- **Language**: C# with .NET 8.0

## Project Structure

```
WebAPIWithLiteDB/
├── Controllers/
│   └── StoreController.cs          # API endpoints
├── Model/
│   └── StoreItem.cs               # Data model
├── Services/
│   ├── IDatabaseService.cs        # Database interface
│   ├── IStoreService.cs          # Business logic interface
│   └── Implementation/
│       ├── DatabaseService.cs     # Database operations
│       └── StoreService.cs       # Business logic
├── Program.cs                     # Application entry point
└── Store.db                      # LiteDB database file
```

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/Store` | Get all store items |
| GET | `/Store/{id}` | Get item by ID |
| POST | `/Store` | Create new item |
| PUT | `/Store/{id}` | Update existing item |
| DELETE | `/Store/{id}` | Delete item |

## Data Model

```csharp
public class StoreItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
```

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- Visual Studio 2022 or VS Code

### Installation

1. Clone the repository:
```bash
git clone <repository-url>
cd WebAPIWithLiteDB
```

2. Restore packages:
```bash
dotnet restore
```

3. Run the application:
```bash
dotnet run
```

4. Navigate to `https://localhost:7198/swagger` to view the API documentation

## Usage Examples

### Create a new item
```bash
curl -X POST "https://localhost:7198/Store" \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Laptop",
    "description": "Gaming laptop with RTX 4070",
    "price": 1299.99
  }'
```

### Get all items
```bash
curl -X GET "https://localhost:7198/Store"
```

### Update an item
```bash
curl -X PUT "https://localhost:7198/Store/1" \
  -H "Content-Type: application/json" \
  -d '{
    "id": 1,
    "name": "Gaming Laptop",
    "description": "Updated description",
    "price": 1199.99
  }'
```

## Architecture Highlights

- **Repository Pattern**: [`DatabaseService`](Services/Implementation/DatabaseService.cs) handles all database operations
- **Service Layer**: [`StoreService`](Services/Implementation/StoreService.cs) contains business logic
- **Dependency Injection**: Services are registered in [`Program.cs`](Program.cs)
- **Interface Segregation**: [`IDatabaseService`](Services/IDatabaseService.cs) and [`IStoreService`](Services/IStoreService.cs) define contracts

## API Documentation

The API includes comprehensive Swagger documentation available at `/swagger` when running in development mode.

![API Documentation](https://github.com/user-attachments/assets/2441e09b-4824-4092-93e5-c1e18b0e512c)

## License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.
