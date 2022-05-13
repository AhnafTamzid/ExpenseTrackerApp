<div id="top"></div>
<!--
*** Thanks for checking out the my project. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go check out my project! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->



<!-- PROJECT HEADING -->

  <h3 align="center">Expense Tracker App</h3>

  <p align="center">
    An Awesome Expense Tracking App for Your Daily Expenditure Tracking in Different Categories!
    <br /><br /><br />
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
        <li><a href="#screenshots">Screenshots</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Local Building</a>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

This is a basic expense tracker app. This is developed to keep track of daily expenditure in different categories & performing CRUD operations. There's no advance features available right now but will be available on future updates hopefully :)


<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

This application is built with ASP.NET CORE Version: 6.0.202 with Entity Framework Core Version 6.0.4.

* [.NET CORE](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
<p align="right">(<a href="#top">back to top</a>)</p>


# Screenshots

### Expense Listing

<img src="/ExpenseTrackerApp/Images/Screenshot_20220513-171242_MX%20Player.jpg" alt="Expense Listing" width="100%" />

### Add Expense

<img src="/ExpenseTrackerApp/Images/Screenshot_20220513-171258_MX%20Player.jpg" alt="Add New Expense" width="100%" />

### Add Category

<img src="/ExpenseTrackerApp/Images/Screenshot_20220513-171306_MX%20Player.jpg" alt="Add New Category" width="100%" />

<!-- LOCAL BUILDING -->
## Local Building

- Install [.NET Core SDK](https://dotnet.microsoft.com/download)
- Go to ExpenseTrackerApp folder and run `dotnet restore` and `dotnet build`
- Run `dotnet run` to start the server at `http://localhost:5177/`
- You can also Install [Microsoft Visual Studio 2022](https://visualstudio.microsoft.com/vs/) Community Edition for free which I've used to develop this project.
- For Database usage Install [MS SQL SERVER MANAGEMENT STUDIO](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)

<br /><br />

<!-- USAGE EXAMPLES -->
## Usage

- Create a database named ExpenseTrackerApp
- Open program.cs file and change connection string to : string cs = "server=.;database=ExpenseTrackerApp;trusted_connection=true";
- Open Package Manager Console for database table creation with code-first approach.
- Run the commands "Add-Migration new" & "update-database"
- Run the program

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- CONTACT -->
## Contact

Ahnaf Tamzid - [@Email](https://gmail.com) - tamztonmoy16@gmail.com

Project Link: [Expense Tracker App](https://github.com/AhnafTamzid/ExpenseTrackerApp)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [.NET CORE MVC](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)
* [Repository Pattern and Unit of Work](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
* [Entity Framework Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-6.0)
* [Bootstrap 5](https://getbootstrap.com/docs/5.0/getting-started/introduction/)

<p align="right">(<a href="#top">back to top</a>)</p>
