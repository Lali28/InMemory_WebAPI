# In-Memory Project Management API

## Project Overview

The **In-Memory Project Management API** is a demonstration of a RESTful Web API built using **ASP.NET Core**. This project simulates a project management system where clients and projects are managed using basic CRUD (Create, Read, Update, Delete) operations.

The API does not rely on a physical database like SQL Server. Instead, it uses **Entity Framework Core's In-Memory provider** to store data, which makes it ideal for quick demonstrations or testing purposes without setting up an actual database. When the API runs, the data is stored temporarily in memory and is lost when the application stops.

This project is designed to show how to:
- Implement CRUD functionality.
- Use in-memory storage in place of a relational database.
- Create an ASP.NET Core Web API with clean architecture.
- Utilize Swagger for interactive API documentation.

## Technologies Used
- **ASP.NET Core 8**: The framework used for building the Web API.
- **Entity Framework Core InMemory**: The data provider used for in-memory storage.
- **Swagger**: For automatically generating interactive API documentation.
- **C#**: The programming language used for API development.

## API Architecture

The API follows REST principles, providing standard HTTP methods for interacting with resources:
- `GET` for retrieving data.
- `POST` for creating new resources.
- `PUT` for updating existing resources.
- `DELETE` for removing resources.

All requests and responses are handled in **JSON** format, which is a standard data exchange format for web services.

## Endpoints

### Project Resource
The API exposes the following endpoints for interacting with the **Project** resource:

| Method | Endpoint               | Description                               |
|--------|------------------------|-------------------------------------------|
| `GET`  | `/api/projects`         | Retrieves a list of all projects.         |
| `GET`  | `/api/projects/{id}`    | Retrieves a project by its ID.            |
| `POST` | `/api/projects`         | Creates a new project.                    |
| `PUT`  | `/api/projects/{id}`    | Updates an existing project by its ID.    |
| `DELETE` | `/api/projects/{id}` | Deletes a project by its ID.              |

### Project Model
The **Project** model contains the following fields:
- **ProjectId** (`int`): The unique identifier for a project.
- **ProjectName** (`string`): The name of the project.
- **Client** (`string`): The client associated with the project.
- **CostSavingsPerMonth** (`decimal`): The estimated cost savings of the project per month.
- **TimeSavingsPerMonth** (`decimal`): The estimated time savings of the project per month.

## Future Enhancements
Some possible future improvements to this project include:
- Adding authentication and authorization for securing the API.
- Integrating a physical database like SQL Server, or MySQL.
- Implementing logging and error handling.
- Creating unit and integration tests for the API.

## License
This project is licensed under the **MIT License**. You are free to use, modify, and distribute this project as long as proper credit is given.
