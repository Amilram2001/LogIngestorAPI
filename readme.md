# Log Ingestor API Overview

Efficiently manage log ingestion with this ASP.NET Core-based Log Ingestor API, utilizing C# and SQLite 3.

## Implemented Features

1. **Insert Log:** Easily add new logs to the system.
2. **Retrieve Logs:** Access all inserted logs effortlessly.
3. **Full Text Search:** Perform text searches across logs.
4. **Filtering:** Apply multiple filter rules to refine log queries.

## Requirements

Ensure your machine meets the following prerequisites:

1. **Dotnet SDK (version 7 or later)**
2. **SQLite 3**
3. **IDE compatible with .NET Development (JetBrains Rider Recommended)**

## Development Tools & Stack

Tools and technologies used for this API:

1. **SQLite 3:** Swift and effective for rapid prototyping.
2. **ASP.NET Core:** Core framework for web applications in the .NET ecosystem.
3. **Swagger:** Primary tool for documenting REST APIs with an interactive interface.
4. **Entity Framework Core:** ORM tool providing a convenient database abstraction layer.
5. **C# Programming Language:** Primary language for API implementation.
6. **Postman API Platform:** Recommended for checking and testing API endpoints.

## Installation Instructions

Set up the Log Ingestor API on your machine:

1. **Clone the repository:**
   ```
   git clone https://github.com/Amilram2001/LogIngestorAPI.git
   ```

2. **Run the Project:**
   Use the dotnet CLI to run the project:
   ```
   dotnet run
   ```
   Note: Run EF Core migrations and schema update for the first build. [Learn More](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)

3. **Explore API Endpoints:**
   Access the Swagger UI at [http://localhost:5038/swagger/index.html](http://localhost:5038/swagger/index.html) (no trailing slash).

## Endpoint Samples

#### Fetch all log data (GET)
- Endpoint: [http://localhost:5038](http://localhost:5038)
- Sample Result:
  ```json
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
- Endpoint: [http://localhost:5038](http://localhost:5038) (Use POST)
- Request Body Structure:
  ```json
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
- Endpoint: [http://localhost:5038/filter](http://localhost:5038/filter) (Use POST)
- Add one or more fields based on requirements:
  ```json
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