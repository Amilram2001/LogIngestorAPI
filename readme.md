# Log Ingestor API
 This API efficiently manages log ingestion and is constructed using ASP.NET Core, C#, and SQLite 3.

## Requirements

Ensure your machine is equipped with the following prerequisites before proceeding:

1. **Dotnet SDK (version 7 or later)**
2. **SQLite 3**
3. **Any IDE compatible with .NET Development (JetBrains Rider Recommended)**

## Development Tools & Stack Used

Here's a concise overview of the tools and technologies implemented for this Log Ingestor API:

1. **SQLite 3:** Swift and effective database solution for rapid prototyping.
2. **ASP.NET Core:** The core framework for developing web applications in the .NET ecosystem.
3. **Swagger:** Primary tool for documenting REST APIs, featuring an interactive interface for testing and exploration.
4. **Entity Framework Core:** A convenient database abstraction layer, functioning as an Object-Relational Mapping (ORM) tool.
5. **C# as the Programming Language:** The primary language for implementing API functionality.
6. **Postman API Platform:** Recommended for checking and testing API endpoints to ensure functionality.

## Installation Instructions

Let's set up the Log Ingestor API on your machine. Ensure you have met the requirements, and then follow these straightforward steps:

1. **Clone the repository:**
   ```
   git clone https://github.com/Amilram2001/LogIngestorAPI.git
   ```
2. **Open in an IDE:**
   - Launch your preferred IDE supporting .NET development.

3. **Run the Project:**
   - Click the run button to start the project. If Swagger opens with a different URL initially, no worries.
   - Alternatively, you can use dotnet cli to run the project using command line
      ```
        dotnet run
      ```

4. **Explore API Endpoints:**
   - Access the Swagger UI to interact with and test the API at [http://localhost:5038/swagger/index.html](http://localhost:3000/swagger/index.html) (ensure no trailing slash in the URL).

## Endpoint Samples

#### Fetch all log data (GET)
- Endpoint: [http://localhost:5038](http://localhost:3000)
- Result Sample (if data exists):
 ```
[{
   "level": "string",
   "spanId": "string",
   "commit": "string",
   "message": "string",
   "traceId": "string",
   "resourceId": "string",
   "timestamp": "2023-11-19T14:54:07.538Z",
   "parentResourceId": "string"
}]
```

#### Add a new log (POST)
- Endpoint: [http://localhost:5038](http://localhost:3000) (Use POST as the request type)
- Request Body Structure:
 ```
{
   "level": "string",
   "spanId": "string",
   "commit": "string",
   "message": "string",
   "traceId": "string",
   "resourceId": "string",
   "timestamp": "2023-11-19T14:54:07.538Z",
   "parentResourceId": "string"
}
```

#### Filtering Logs with support for multiple fields (POST)
- Endpoint: [http://localhost:5038/filter](http://localhost:3000/filter) (Use POST as the request type)
- Add one or more fields based on requirements:
 ```
{
   "level": "string",
   "spanId": "string",
   "commit": "string",
   "message": "string",
   "traceId": "string",
   "resourceId": "string",
   "from": "2029-11-19T14:54:07.538Z",
   "to": "2023-11-19T14:54:07.538Z",
   "parentResourceId": "string"
}
```