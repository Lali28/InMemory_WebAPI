
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
- **ASP.NET Core 7/8**: The framework used for building the Web API.
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

### Example Project Object

```json
{
    "projectId": 1,
    "projectName": "Automation Enhancement",
    "client": "Tech Solutions Ltd.",
    "costSavingsPerMonth": 3000.00,
    "timeSavingsPerMonth": 120.00
}
```

## Setting Up the Project Locally

### Prerequisites
To run this project locally, ensure you have the following installed:
- **.NET SDK 7 or 8** (for ASP.NET Core development)
- **Visual Studio 2022** (or any IDE that supports .NET Core development)
- **Git** (to clone the repository)

### Installation Steps

1. **Clone the Repository**  
   Clone the project repository to your local machine:
   ```bash
   git clone https://github.com/your-username/InMemoryProjectAPI.git
   ```

2. **Navigate to the Project Directory**  
   Once cloned, navigate to the project folder:
   ```bash
   cd InMemoryProjectAPI
   ```

3. **Open the Solution in Visual Studio**  
   Open the `.sln` file in Visual Studio to work with the project.

4. **Restore NuGet Packages**  
   Ensure all dependencies are restored. Visual Studio should automatically restore NuGet packages, but you can also do this manually by running:
   ```bash
   dotnet restore
   ```

5. **Run the Project**  
   Run the project from Visual Studio or using the following command:
   ```bash
   dotnet run
   ```
   The API will start running locally on `https://localhost:5001`.

6. **Access Swagger for API Testing**  
   Once the API is running, you can access **Swagger UI** for interactive testing:
   - Navigate to: `https://localhost:5001/swagger`
   - Swagger provides a user-friendly interface to test each of the API endpoints.

### Sample Requests

#### 1. **Get All Projects**
   - **Method**: `GET`
   - **Endpoint**: `/api/projects`
   
   Example response:
   ```json
   [
       {
           "projectId": 1,
           "projectName": "Automation Enhancement",
           "client": "Tech Solutions Ltd.",
           "costSavingsPerMonth": 3000.00,
           "timeSavingsPerMonth": 120.00
       },
       {
           "projectId": 2,
           "projectName": "Digital Transformation",
           "client": "Innovative Corp.",
           "costSavingsPerMonth": 5000.00,
           "timeSavingsPerMonth": 200.00
       }
   ]
   ```

#### 2. **Get Project by ID**
   - **Method**: `GET`
   - **Endpoint**: `/api/projects/{id}`

   Example:
   - Request: `/api/projects/1`
   - Response:
     ```json
     {
         "projectId": 1,
         "projectName": "Automation Enhancement",
         "client": "Tech Solutions Ltd.",
         "costSavingsPerMonth": 3000.00,
         "timeSavingsPerMonth": 120.00
     }
     ```

#### 3. **Create a New Project**
   - **Method**: `POST`
   - **Endpoint**: `/api/projects`
   - **Request Body**:
     ```json
     {
         "projectName": "Cloud Migration",
         "client": "CloudCo",
         "costSavingsPerMonth": 4500.00,
         "timeSavingsPerMonth": 180.00
     }
     ```

   Example Response:
   ```json
   {
       "projectId": 3,
       "projectName": "Cloud Migration",
       "client": "CloudCo",
       "costSavingsPerMonth": 4500.00,
       "timeSavingsPerMonth": 180.00
   }
   ```

#### 4. **Update a Project**
   - **Method**: `PUT`
   - **Endpoint**: `/api/projects/{id}`
   - **Request Body**:
     ```json
     {
         "projectId": 1,
         "projectName": "Automation Enhancement - Updated",
         "client": "Tech Solutions Ltd.",
         "costSavingsPerMonth": 3200.00,
         "timeSavingsPerMonth": 130.00
     }
     ```

#### 5. **Delete a Project**
   - **Method**: `DELETE`
   - **Endpoint**: `/api/projects/{id}`

## Running Tests
There are no unit tests provided in this version of the project. However, you can use the Swagger UI or tools like **Postman** to manually test the API functionality by sending HTTP requests.

## Contributions
If you'd like to contribute to this project, feel free to fork the repository and submit a pull request with your enhancements. Contributions that improve functionality, add more detailed documentation, or include database integration (e.g., SQL Server) are highly encouraged!

## Future Enhancements
Some possible future improvements to this project include:
- Adding authentication and authorization for securing the API.
- Integrating a physical database like SQL Server, PostgreSQL, or MySQL.
- Implementing logging and error handling.
- Creating unit and integration tests for the API.

## License
This project is licensed under the **MIT License**. You are free to use, modify, and distribute this project as long as proper credit is given.

---

### That's the full **README** for your Web API project! You can customize it further if necessary. Let me know if you'd like help with anything else!
