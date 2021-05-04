
#How to run
Build the project to restore all packages and dependencies 

Inside appsettings.json change the "DefaultConnection" string to your local SQL instance

In the "Package Manager Console" run the command "update-database" this will create and seed the database

Click run ("ISS Express") for the LockheedMartin.DeveloperTest project

This will use IIS and pop up the GUI for you

#Layout of LockheedMartin.DeveloperTest

DAL(Data Access Layer)
Contains database Context and Models

BBL(Business Logic Layer) 
Contains all the logic for the application and DTOs (Data Transfer objects)
Calculate.cs contains the logic to calculate the Mean and Standard Deviation

Mapper
Contains the AutoMapper profile to map between the the database Models and DTO objects

ClientApp
Contains the React GUI

Controllers
Contains the API endpoints

Migrations
Contains the entity framework generated migration code

#Uses
.Net Core 3.1
AutoMapper
EntityFrameworkCore for SQL
React
Highchart
Bootstrap

#The Application 
The home page allows you to view and add weeks
To add a new week enter a name and click "Add"
Once you have added a week you can view it by clicking "View"
On this screen you will see a a graph and a week list of days
On the each day panel you can add new temperatures by typing new number a clicking "Add"
The week list and graph will update automatically for you to display the new temperature
The graph will show you the temperatures, mean and standard deviation
You can click on "Home" or the "LockheedMartin.DeveloperTest" to view all weeks again

*if you get an error message on the home page it's probably the database doesn't exist