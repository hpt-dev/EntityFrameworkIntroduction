# EntityFrameworkIntroduction
This contains the project from part 1 of my entity framework playlist. To follow along here is the video:

https://www.youtube.com/watch?v=A4tpHy__LN0&t=917s

In this video you'll learn how to setup and configure Entity Framework using a .NET 6 Web API as an example project. We will cover everything you need to know about migrations and creating a database. This is part of a playlist that covers everything you need to know about Entity Framework.

▬ Contents of this video  ▬▬▬▬▬▬▬▬▬▬
0:00 - Introduction, create a new Project
1:18 - Entityframework Nuget Packages
3:27 - Creating an entity/model
5:33 - Understanding and creating the DbContext
8:42 - Database connection string
9:14 - First migration and database creation
13:35 - Making changes to your model and adding a second migration
14:45 - Reverting a migration
16:31 - Genertating a SQL script from a migration

Video Notes
1. Using different database provider (e.g. SQLLite, MySQL or Cosmo Db)
https://docs.microsoft.com/en-us/ef/c...
https://docs.microsoft.com/en-us/ef/c.... 
https://docs.microsoft.com/en-us/azur...

Database first entity framework:
https://www.entityframeworktutorial.n...

Github Link for the Project from this video:
https://github.com/hpt-dev/EntityFram...

Useful snippets from the video:
1. Packages to Install:
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityframeworkCore.Tools
Microsoft.EntityFrameworkCore.Design

2. Install DotNET Cli
add dotnet-ef install to description

3. Add a Migration
add-migration {migrationName} -verbose

4. Apply migrations to database:
update-database

5. Remove the most recent migration:
remove-migration

6. Get SQL Script for a Migration (will write file to project folder):
script-migration -o ./fileName.sql 

7. Move database back to a previous migration:
update-database {previousMigrationName

8. Database connection string:
  "ConnectionStrings": {
    "BloggingDatabase": "Server=(localdb)\\mssqllocaldb;Database=EFCoreTestProj;Trusted_Connection=True;"
  }

9. DbContext registration with Dependency Injection:
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BloggingDatabase")))
