# 📚 BulkyBook

BulkyBook is a full-featured ASP.NET Core MVC web application built with Entity Framework Core and the Identity framework. It serves as an online bookstore with full CRUD functionality, admin dashboard, user authentication, and a responsive UI.

## 🚀 Features

- ASP.NET Core MVC architecture
- Entity Framework Core with Code-First approach
- SQL Server database integration
- Identity Framework for authentication and authorization
- Admin panel for managing:
  - Categories
  - Cover Types
  - Products
- Responsive design using Bootstrap 5
- Clean and modular architecture (Repository + Unit of Work patterns)
- Separated layers: Models, DataAccess, Web (Presentation)

## 📂 Project Structure

BulkyBook/
├── BulkyBook.Models # POCO classes for data models
├── BulkyBook.DataAccess # ApplicationDbContext, Repositories, Migrations
├── BulkyBook.Utility # Constants, static helpers (if any)
├── BulkyBookWeb # MVC Web App (Views, Controllers, wwwroot)

