# Coalesce

<img height="949" alt="Screenshot 1" width="800" src="https://github.com/user-attachments/assets/76edd6aa-83a9-4c79-a9f7-686037005e65" />
<img height="949" alt="Screenshot 2" width="800" src="https://github.com/user-attachments/assets/2d38cb87-b12a-44b4-903a-6acecc93a826" />

# About the project
This ASP.NET MVC application combines daily productivity tools with robust data management capabilities. It allows users to plan their schedule, track expenses, and record important events, keeping everything organized from morning tasks to evening plans. Built with modern architectural principles, it includes a well-structured layered design, dependency injection, data validation, and centralized error handling. The app also supports full CRUD functionality for managing records, ensuring that users can easily create, view, update, and delete their data while maintaining reliability and scalability.

# Key Features
- **CRUD Operations**: Create, Read, Update, and Delete human records.
- **Repository Pattern**: Encapsulates data access logic, keeping controllers clean and maintainable.
- **Validation**: Server-side validation using Data Annotations to ensure data integrity.
- **Database Integration**: Entity Framework Core with InMemory database for data storage and easy testing.
- **Routing & Response Types**: Explicit routes and `ProducesResponseType` for clear API documentation.
- **MVC Pattern**: Separation of concerns with Models, Views, and Controllers for cleaner structure and scalability.
- **Strongly Typed Views**: Ensures compile-time safety and reduces runtime errors when rendering data in the UI.
- **Razor View Engine**: Dynamic page rendering with clean and maintainable markup.
- **Dependency Injection**: Built-in DI container for injecting services and repositories across controllers.
- **Model Binding & Validation**: Automatic mapping of HTTP requests to action parameters with validation checks.
- **ViewData, and ViewBag**: State management mechanisms to pass data between controllers and views.

# Technologies:
ASP.NET MVC, C#, Entity Framework, Razor Views, LINQ, Data Annotations, Bootstrap / CSS, Dependency Injection, Routing

# Purpose:
This project showcases the ability to build a professional, maintainable, and scalable ASP.NET Core MVC application, demonstrating practical knowledge of application architecture, error handling, validation, and database interaction. It also provides full functionality for data manipulation and presentation, allowing users to create, read, update, and delete records through an intuitive user interface.

# Getting Started:
## Installation:
- git clone https://github.com/Kirillius7/Coalesce
- cd project
- dotnet restore
- dotnet build
- dotnet run
## Requests:
- https://localhost:7038/Expense/CreateEditExpense - запит для створення нового або зміни наявного запису про витрати у базі даних 
- https://localhost:7038/Date/Dates - запит на виведення всіх наявних дат із бази даних
 
# Contacts:
https://www.linkedin.com/in/kyrylo-popov-ab160536a/

