# RaceDay RESTful Web API
Part 2 PoE Project - .NET 8.0 & SQL Server

## Database Configuration
- Uses Entity Framework Core 8.0.8
- Database name: RaceDayDb_Part2

## API Endpoints
- POST /api/auth/register
- POST /api/auth/login
- GET /api/events
- POST /api/events
- POST /api/enrolments

## Prerequisites
- .NET 8.0 SDK
- SQL Server Express / LocalDB
- Visual Studio 2022

## Testing with Swagger
1. Launch the application (F5).
2. Navigate to `https://localhost:<port>/swagger`.
3. Execute `POST /api/auth/register` to create a user account.
4. Execute `POST /api/auth/login` to establish session authorization.
