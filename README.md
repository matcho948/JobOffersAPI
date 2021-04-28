# JobOffersAPI
This repository contains an API written in C# and ASP.NET Core 5.0. This API use MS SQL Server as database server.
## How to run it?
  1. Clone this repository 
  2. Build the solution using Visual Studio 
  3. In MS SQL Server connect with database using server name "(LocalDb)\MSSQLLocalDB"
  4. Write on command line 'dotnet ef migrations add Migration' then write 'dotnet ef database update'
  5. Run the project  'dotnet run'. This API should start up on https://localhost:5001
  6. Use Postman or other HTTP client to test it out ;)
