# 🧅 Onion Architecture .NET 8 Boilerplate

This project is a clean implementation of Onion Architecture in a .NET 8 Web API, structured for scalability, testability, and separation of concerns. It uses Entity Framework Core and supports dependency injection, service layering, and Swagger for API documentation.

---

## 📁 Project Structure

```
OnionProject/
│
├── Onion.API/                → Presentation Layer
│   └── Program.cs
│   └── Controllers/
|
|
|
├── Onion.Infrastructure/     → Infrastructure Layer
|   └── Configuration/
|        └── DapperContext.cs
|        └── DbContext.cs
|        └── ServiceConfiguration.cs
│   └── External_Services/
│   └── Jobs/
│   └── Repositories/
│   └── Utilities/
│   └── Messagings/
│
|
|
├── Onion.Application/        → Application Layer
│   └── DTOs/
│   └── Services/
│   └── Service_Interfaces/
|
|
│
├── Onion.Domain/             → Domain Layer
│   └── Entities/
│   └── Models/
│   └── Enums
│   └── Pure_Interfaces/
|        └── IExternal_Services/
|        └── IRepositories/
|        └── IUtilities
│
|
│
└── Onion.sln
```

---

## 🔄 Onion Architecture Layers

### 🟣 Domain Layer
- Contains business entities and core domain logic.
- No external dependencies.

### 🟡 Application Layer
- Contains service interfaces, DTOs, and use cases.
- Calls into the Domain Layer.
- Depends on abstractions (interfaces) for repositories.

### 🔵 Infrastructure Layer
- Contains concrete implementations (e.g., `DbContext`, Repositories, third-party services).
- Implements interfaces defined in Application.

### 🟢 Presentation Layer (API)
- Exposes HTTP endpoints.
- Depends only on the Application layer.
- Injects services and orchestrates use cases.

---

## ⚙️ Configuration Steps

### 1. Setup Dependency Injection

In `Infrastructure/DependencyInjection.cs`:

```csharp
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString)); // or UseSqlServer, etc.

        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}
```

In `Program.cs` (API):

```csharp
builder.Services.AddInfrastructure(builder.Configuration);
```

---

## 🔌 Running the Project

```bash
cd Onion.Api
dotnet run
```

If using **VS Code**, set the API project as the startup project in your `launch.json` or check the one i have provided.

---

## 🔍 Swagger UI

Swagger is available by default:

- Navigate to `https://localhost:7215/index.html`
- You'll see the interactive Swagger UI

---



## ✅ Benefits of this Architecture

- Clean separation of concerns.
- Infrastructure can be swapped without affecting domain logic.
- Highly testable components.
- Adheres to SOLID principles.

---

## 🛠️ Technologies Used

- .NET 8
- Entity Framework Core
- PostgreSQL / SQL Server
- Swagger (Swashbuckle)
- Dependency Injection
- Onion Architecture Pattern


---

## Design Pattern
- Strategy Pattern

---

##💡💡💡💡 I will keep you update as I work on the designs based on various use cases