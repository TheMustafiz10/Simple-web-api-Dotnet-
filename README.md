# Simple-web-api-Dotnet- TripApi


A simple controller-based RESTful Web API built with **ASP.NET Core**, **PostgreSQL**, and **Docker**. TripAPI provides a backend foundation for managing trip-related data through organized and maintainable API endpoints.

## Tech Stack

- **Backend:** ASP.NET Core Web API (.NET)
- **Architecture:** Controller-based Architecture
- **Database:** PostgreSQL
- **Containerization:** Docker
- **API Documentation:** Swagger / OpenAPI

## Features

- RESTful API architecture
- Controller-based request handling
- PostgreSQL database integration
- Docker support for containerization
- Swagger API documentation
- Clean and maintainable project structure

## Prerequisites

Before running the project, make sure you have installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [PostgreSQL](https://www.postgresql.org/) (if running without Docker)

## Installation & Setup

### 1. Clone the Repository

```bash
git clone https://github.com/USERNAME/TripAPI.git
cd TripAPI
```

### 2. Configure the Database

Update your PostgreSQL connection string in `appsettings.json`.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=TripDB;Username=postgres;Password=your_password"
  }
}
```

Replace the credentials with your PostgreSQL configuration.

### 3. Restore Dependencies

```bash
dotnet restore
```

### 4. Run the Application

```bash
dotnet run
```

The API will start on the configured application URL.

## Running with Docker

### Build the Docker Image

```bash
docker build -t tripapi .
```

### Run the Container

```bash
docker run -p 8080:8080 tripapi
```

Make sure PostgreSQL is accessible from the container and the database connection string is configured correctly.

## API Documentation

If Swagger is enabled, access the interactive API documentation at:

```text
http://localhost:8080/swagger
```

## Project Structure

```text
TripAPI/
│
├── Controllers/
│
├── Models/
│
├── Data/
│
├── Properties/
│
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── Dockerfile
├── .gitignore
└── TripAPI.csproj
```

*Note: The project structure may vary depending on the implementation.*

## Useful Commands

| Command | Description |
|---|---|
| `dotnet restore` | Restore project dependencies |
| `dotnet build` | Build the application |
| `dotnet run` | Run the API |
| `dotnet watch run` | Run with hot reload |
| `docker build -t tripapi .` | Build Docker image |
| `docker ps` | List running containers |
| `docker images` | List Docker images |

## Contributing

Contributions, suggestions, and improvements are welcome!

1. Fork the repository.
2. Create a new branch:

   ```bash
   git checkout -b feature/new-feature
   ```

3. Commit your changes:

   ```bash
   git commit -m "Add new feature"
   ```

4. Push your branch:

   ```bash
   git push -u origin feature/new-feature
   ```

5. Open a Pull Request.

## License

This project is open-source. Add a `LICENSE` file to specify the license under which the project is distributed.

---

**Built with sing ASP.NET Core, PostgreSQL, and Docker.**
