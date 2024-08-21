Razor Pages Demo App

Overview
This is a Razor Pages web application demonstrating CRUD 
(Create, Read, Update, Delete) operations using ASP.NET Core and 
Entity Framework Core with a SQLite database. The app manages employee records, 
including their names, emails, salaries, dates of birth, and departments.

Features
- Create new employee records
- View a list of all employees
- Update existing employee details
- Delete employees from the database

Prerequisites
.NET 6 SDK or later
A code editor like Visual Studio or Visual Studio Code

Setup Instructions
1. Clone the repository:

run in bash
git clone https://github.com/MarksmanX/RazorPagesCRUDdemo.git
cd razor-pages-demo-app

2. Restore NuGet packages:
In the terminal or package manager console, run:

dotnet restore

3. Update the database:
Entity Framework Core will use SQLite to create the necessary database file. 
Run the following command to apply migrations and create the database:

dotnet ef database update
This will generate a RazorPagesDemo.db file in the root of the project directory.

4. Run the application:
Start the application by running:

dotnet run
Then, open a browser and navigate to https://localhost:5001 (or the URL shown in the console) to use the application.

Database Notes
The app uses SQLite, so there’s no need to set up a separate database server.
The database file RazorPagesDemo.db will be automatically created in the root of the project when you run the dotnet ef database update command.