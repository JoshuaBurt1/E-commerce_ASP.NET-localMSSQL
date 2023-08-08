# To Run

#MS SQL Server (local database)

1.	CREATE DATABASE QuartzCreations;
   
#note: to run on an external database (Azure)
A. Create an Azure account 
B. Create a resource group
C. Create an SQL Server
D. Create an SQL Database - obtain connection string from Azure and apply to appsettings.json "Default Connection": "copied connection string"

#VISUAL STUDIO (upper left)

1.	Add Connection:
Enter ServerName: “name”
Select or Enter a database name: “QuartzCreations”
2.	Right click on newly added connection, Properties, Connection String ->copy
3.	In appsettings.json “Default Connection”: “copied connection string”
4.	In NuGet package manager:
Add-migration InitialModels
Update-database
5.	Run program (Start without debugging)

