# Disney-Api

## Packages NuGet installed:

**Project version .NET SDK 6.0.201**
- Microsoft.EntityFrameworkCore (6.0.3)
- Microsoft.EntityFrameworkCore.Design (6.0.3)
- Microsoft.EntityFrameworkCore.SqlServer (6.0.3)
- Microsoft.EntityFrameworkCore.Tools (6.0.3)
- Swashbuckle.AspNetCore (6.2.3)

## Configure the connection string of your Database

- Set the *appsetings.json* file with your *DefaultConnection*:

````
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost; Database=Disney; Trusted_Connection=True;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

````

**Create the first migration with the command:**

- .NET Core CLI:

````
dotnet ef migrations add MIGRATION_NAME

````

- Visual Studio:

````
Add-Migration MIGRATION_NAME

````

**Create the database with the command:**

- .NET Core CLI:

````
dotnet ef database update

````

- Visual Studio:

````
Update-Database

````

