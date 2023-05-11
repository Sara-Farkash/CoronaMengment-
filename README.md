# CoronaMengment-
Simulation - ASP.NET Core Web Application
This is a C# project developed in ASP.NET Core Web Application 
using the 4-layer Entity Framework method and Swagger  
for API documentation.
The project simulates a Mengment for HMO for Covid with 3 tables:
Ill, Vecanition, User1 

# Prerequisites 
- Visual Studio 2022
- .NET Core
- SQL Server

# To Begin :
1. please download the project to your local machine.
2. open the project in Visual Studio.
3. open your Sql Server and when you connect to sql you need to see the "conntion string"
4. copy the connection strint
5. paste the "conntion string" in : layer Entity-> file database -> you should see my "conntion string" so replace and paste there
6. Open the Package Manager Console and run the following command to create the database:
  add-migrtion init1
  Update-Database init1
7. Build and run the project.
 
The project follows the 4-layer Entity Framework method, 
which separates the application into the following layers:
The project also uses Swagger for API .

Now you can add values in the Swagger 
and they will be updated in the database. 
Note that you must enter logical and correct data because otherwise the data will not enter the database.
For example you want to enter a new user
You go to the "post" button and then you fill in the data and run
Now if you want to see the data you added you must use the "get" button,
So for every table
#Emphasis:
You will not be able to produce a vaccine before a person because you have no one to vaccinate!
And a sick person also cannot be created before a person because if there is no person then there is no sick person!

# Note ❤
A solution to exercise part I for the bonus question (2) is also attached in PDF file F
Solution to exercise part 2 is also attached in PDF file

Successfully !
Hope you enjoy the project !
