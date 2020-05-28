
---------------------------------------README---------------------------------------

1. Download these packages by using Package NuGet Manager;
	1.1. Download Microsoft.EntityFrameworkCore.SqlServer
	1.2. Download Microsoft.EntityFrameworkCore.Tools
2. Open a Folder named "Infrastructure"
	2.1. Open a Folder named "Context"
		2.1.1. Add a class named "ProjectContext.cs"
3. Add a class named "Page.cs" into "Model" Folder.
4. Do DbSet for "Page" entity.
5. Migration processes will start.
6. Open a Folder named "Seeding" into Infrastructure folder.
	6.1. Add a class named "SeedData.cs"
	6.2. Organize the Program.cs
7. Start the Project and check the database.