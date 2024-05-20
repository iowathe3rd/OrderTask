# Order management task app (backend)

This project is an Order management task app developed using ASP.NET Core Web API and PostgreSQL database.

## Prerequisites

Before running the project, make sure you have the following installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or higher)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (if you want to run the PostgreSQL database in a Docker container)

## Installation

1. Clone the repository to your local machine:
   ```
   git clone https://github.com/yourusername/your-repository.git
   ```

2. Navigate to the project directory:
   ```
   cd Order
   ```

3. Install the required dependencies:
   ```
   dotnet restore
   ```

4. If you are using Docker for the PostgreSQL database, start the Docker container:
   ```
   docker-compose up -d
   ```

## Database Migration

1. Ensure that your PostgreSQL database is running.

2. Apply the database migrations to create the required tables:
   ```
   dotnet ef database update
   ```

## Running the Application

1. Start the ASP.NET Core Web API:
   ```
   dotnet run
   ```

2. The application will start and be accessible at `https://localhost:5001`.

## Testing the API

You can test the API endpoints using a tool like [Postman](https://www.postman.com/). Here are the example endpoints:

- **GET** `/api/orders` - Get all orders
- **POST** `/api/orders` - Create a new order
- **GET** `/api/orders/{id}` - Get an order by ID
- **DELETE** `/api/orders/{id}` - Delete an order by ID

Make sure to replace `{id}` with the actual ID of the order.