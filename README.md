# Task1 - User Management Web App (ASP.NET Core MVC + SQLite)

A simple web application for **creating, viewing, editing, and deleting users**, built with ASP.NET Core MVC (.NET 8), Entity Framework Core, and SQLite.

## Features

- [x] Add new users (Full Name, Email, Date of Birth, Phone Number)
- [x] Display list of registered users
- [x] Edit and delete users
- [x] Responsive UI with Bootstrap (dark mode)
- [x] Data stored locally in SQLite (`users.db`)

## Technologies Used

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core (Code First)
- SQLite
- Bootstrap 5
- Razor View Engine (cshtml)

## How to Run Locally

> **Requirement**: [.NET 8 SDK](https://dotnet.microsoft.com/download)

### 1. Clone project

```bash
git clone https://github.com/cuongtr1704/UserManagement.git
cd Task1
```

### 2. Restore required packages

```bash
dotnet restore
```

### 3. Build and run

```bash
dotnet run
```
