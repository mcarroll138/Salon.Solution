# **Eau Claire's Hair Salon**

### By Michael Carroll

A webpage application using C# to create and use a database to store both Employees and Clients in a database and link them by using one to many relationships.
Link to GH Page:
 
https://github.com/mcarroll138

## Technologies used 
- HTML
- CSS
- C#
- .NET 6.0
- MySQL Workbench
- SQL Database
- AspNetCore
- Entity Framework
- Linq
- Mvc


## Complete setup/installation instructions 
- Clone this repository from GitHub
- Navigate to the HairSalon directory in your terminal and create a new file called appsettings.json
- Within this file add the following lines of code:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=michael_carroll;uid=root;pwd=epicodus;",
    "TestConnection": "Server=localhost;Port=3306;database=michael_carroll;uid=root;pwd=epicodus;"
  }
}
- Open MySQL Workbench and use data import/restore to add the database to your system.
- This will allow you to use the michael_carroll.sql file. 
- NOTE: There is no sensitive material on this database, it has been used only to test the functionality.
- Once this has been set up, navigate to the HairSalon directory and run $ dotnet watch run
- Once page loads, you will be at the Home Page where you can either View the Stylist List or View the Client List. Please note that you must have at least one stylist loaded into the system before you can add any clients.

## Known Bugs

## License
MIT

Copyright (c) 2023 Michael Carroll

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
