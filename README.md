# NETFeatures
An application combining many of the modern features of .NET

This web application currently demonstrates the use of Entity Framework, Asp.NET MVC, Web API, and WCF.

I created this app using the following series of steps:
* Create an asp.net web framework project with MVC
* Add a database to the solution, add tables and post-deployment script
* Run Update-Database in Package Management Console
* Add an Entity Framework Data Model for the tables in the database
* Add an Asp.NET MVC controller with Entity Framework for the tables
* Add a Web API Controller with Entity Framework 
* Add a file WebAPIConfig, if it is not created automatically, and call the register method in the Global.asax.cs file
* To avoid an error with Web API, add an ignore exception to the reference loop handling in WebAPIConfig
