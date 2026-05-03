# 🌐 Razor Pages Website (ASP.NET Core)

![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Razor%20Pages-purple)
![C#](https://img.shields.io/badge/C%23-Programming-green)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen)
![License](https://img.shields.io/badge/License-Educational-lightgrey)

## Description
This project is a simple ASP.NET Core Razor Pages web application that demonstrates the basic structure of a website.

The application includes:
- Home Page
- About Page
- Contact Page with a form

This project was created as part of a course assignment to practice Razor Pages, form handling, and basic web development using ASP.NET Core.

---

## Features
- Home page with a welcome message  
- About page with personal information  
- Contact page with a form:
  - Name  
  - Email  
  - Message  
- Displays a success message after form submission  
- Simple navigation menu  

---

## Technologies Used
- ASP.NET Core (.NET)
- Razor Pages
- C#
- HTML / CSS

---

## Project Structure
Pages/
│── Index.cshtml
│── Index.cshtml.cs
│── About.cshtml
│── About.cshtml.cs
│── Contact.cshtml
│── Contact.cshtml.cs
│
└── Shared/
│── _Layout.cshtml
│── _ViewStart.cshtml
│── _ViewImports.cshtml


---

## How to Run

### Using Visual Studio
1. Open the project in Visual Studio  
2. Click **Start (▶️)** or press `Ctrl + F5`  
3. The browser will open automatically  

---

### Using .NET CLI
dotnet build
dotnet run


Open the URL shown in the terminal (e.g., https://localhost:5001)

---

## Pages Overview

### Home Page
Displays a welcome message.

---

### About Page
Contains information about the developer.

Example: My name is Frans. I am learning ASP.NET Core and C#.


---

###  Contact Page
Contains a form with:
- Name
- Email
- Message

When submitted, the page displays: Thank you for contacting me!


---

##  Learning Outcomes
- Understanding Razor Pages structure  
- Difference between `.cshtml` and `.cshtml.cs`  
- Handling form submission using `OnPost()`  
- Using `[BindProperty]` for form data  
- Creating a basic web application  

---

##  Notes
- This project is for learning purposes only  
- The contact form does not store data in a database  
- No email sending functionality is implemented  

---

## Author
Frans 

Learning ASP.NET Core & Web Development  

---

##  Acknowledgment
This project was completed as part of a course assignment to practice ASP.NET Core Razor Pages.


