# To Run

#IN MS SQL Server (local database)

1.	CREATE DATABASE QuartzCreations;

#IN VISUAL STUDIO (upper left)

1.	Add Connection:
Enter ServerName: “name”
Select or Enter a database name: “QuartzCreations”
2.	Right click on newly added connection, Properties, Connection String ->copy
3.	In appsettings.json “Default Connection”: “copied connection string”
4.	In NuGet package manager:
Add-migration InitialModels
Update-database
5.	Run program (Start without debugging)
