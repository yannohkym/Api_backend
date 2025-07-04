# Api_backend
# InsurancePolicyAPI

## Overview
This project provides a simple ASP.NET Core Web API for managing insurance policies, including CRUD operations.

## Prerequisites
- .NET 6 SDK or later
- SQL Server
- Entity Framework Core CLI (optional, for migrations)
- Visual Studio 2022 or Visual Studio Code

## Setup Instructions

### Clone the Repository
```bash
git clone <repository-url>
cd InsurancePolicyAPI
```

### Configure the Database Connection
1. Open `appsettings.json`.
2. Update the `ConnectionStrings` section with your SQL Server connection details:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;"
   }
   ```

### Run Database Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Run the Application
```bash
dotnet run
```

The API will be available at `https://localhost:5001` or `http://localhost:5000`.

## API Endpoints

### Get All Policies
- **GET** `/api/InsurancePolicies`

### Get Policy by ID
- **GET** `/api/InsurancePolicies/{id}`

### Create Policy
- **POST** `/api/InsurancePolicies`
  - **Body**:
    ```json
    {
      "PolicyHolderName": "John Doe",
      "PolicyNumber": "12345",
      "PolicyType": "Health",
      "PremiumAmount": 100.0,
      "IsActive": true
    }
    ```

### Update Policy
- **PUT** `/api/InsurancePolicies/{id}`
  - **Body**:
    ```json
    {
      "Id": 1,
      "PolicyHolderName": "Jane Doe",
      "PolicyNumber": "12345",
      "PolicyType": "Life",
      "PremiumAmount": 150.0,
      "IsActive": true
    }
    ```

### Delete Policy
- **DELETE** `/api/InsurancePolicies/{id}`

## Additional Notes
- For development, consider using a tool like Postman or Swagger UI for testing the API.
- Refer to the official [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/) for more information.

