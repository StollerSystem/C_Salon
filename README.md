# _MVC Hair Salon_

#### _An app to manage Stylists and their clients, 10/9/20_

#### By _**Ben Stoller**_

## Description

This app will allow you to add Stylists which will be saved to a database. Then you can add Clients which will each be linked to one Stylist. You can navigate to different pages to list stylists/clients, add them, edit and delete them. 
Each page that lists out stylists/clients also has a filter function to search for specific names. 

## Setup/Installation Requirements

## MySQL Workbench Schema Setup:
1. Open [MySql Workbench](https://www.mysql.com/products/workbench/) and connect to Local instance
2. Create a new sql tab by clicking the upper left icon: 'Create A New SQL Tab for Executing Queries'
3. Copy and paste the following code into "Query" and "Run":
---
### **Copy The Following Text**



## Website Setup:
* Download or Clone project from Github repository.
* Open a terminal within HairSalon folder within main project directory.
* Use command: 'dotnet restore' to install.
* After installation, type in 'dotnet build'.
* After build, run the program with 'dotnet run' in the terminal.
* If you don't have it already, create a "appsettings.json" file in the "HairSalon" directory and Insert the code below with your user name and password for MySQL: 

> {
>  "ConnectionStrings": {
>      "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid={YOUR USERNAME};pwd={YOUR USERNAME}"
>  }
>}

* Follow terminal prompts to see application run.


## Known Bugs

None at the moment 

## Support and contact details

https://github.com/StollerSystem

## Technologies Used

C#, LINQ, Entity Framework Core, MVCTest, MySql, CSHTML, CSS, Bootstrap and Markdown.


### License

MIT

Copyright (c) 2020 **_Ben Stoller_**

