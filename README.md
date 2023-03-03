# 📋 _Vendor & Order Tracker_ 📋

#### By Eliot Gronstal

#### 🚚 🥖 _A MVC application to help a baker track the vendors that purchase baked goods from them and the orders belonging to those vendors. Independent Code Review for Week 2 of C# at Epicodus Coding School._ 🚚 🥖

## Technologies Used

* 🗄️ _C#_
* 🗄️ _.NET_
* 🗄️ _MSTest_
* 🗄️ _HTML_
* 🗄️ _CSS_
* 🗄️ _Razor_

## Description

A MVC application to help a baker track the vendors that purchase baked goods from them and the orders belonging to those vendors.

This project:

* 🛒 _Uses Razor to display information on each page._

* 🛒 _Has a Vendor class. This class includes properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor._

* 🛒 _Has an Order class. This class includes properties for the title, the description, the price, and the date._

* 🛒 _The homepage of the app at the root path [localhost:5000/] is be a splash page welcoming the baker and providing them with a link to a Vendors page._

* 🛒 _The vendors page contains a link to a page presenting the baker with a form they can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and the baker should be routed back to the homepage._

* 🛒 _The baker is able to click a Vendor's name and go to a new page that will display all of that Vendor's orders._

* 🛒 _The baker is provided with a link to a page presenting them with a form to create a new Order for a particular Vendor._

## Setup/Installation Requirements

* 🗄️ _Clone this repo._
* 🗄️ _Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "VendorOrderTracker"._
* 🗄️ _In the command line, run the command ``dotnet run`` to compile and execute the application._
* 🗄️ _Optionally, you can run ``dotnet build`` to compile this console app without running it._
* 🗄️ _If we want to run our project in production mode with a watcher, we can use a command line flag to specify that we want to run the "production" profile. ``dotnet watch run --launch-profile "production"``_
* 🗄️ _Open the browser to [https://localhost:5001]. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this link: [Redirecting to HTTPS and Issuing a Security Certificate.](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate)_

## Test Instructions

* 🗄️ _Using a shell program, navigate from the root directory, "VendorandOrderTracker.Solution," to the "VendorOrderTracker.Tests" directory._
* 🗄️ _Once in the "VendorOrderTracker.Tests" directory, type ``dotnet restore`` into the console._
* 🗄️ _After the restore process is complete, type ``dotnet test`` into the console. This will run all written tests and display the test results into the console to review._

## Known Bugs

* 📋 _Any known issues_

* 📋 _Please reach out with any questions or concerns to [eliot.lauren@gmail.com](eliot.lauren@gmail.com)_

## License

_[MIT](https://opensource.org/license/mit/)_

Copyright (c) _2023_ _Eliot Gronstal_