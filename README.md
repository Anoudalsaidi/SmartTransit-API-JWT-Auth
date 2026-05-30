# 🚆 Smart Transit API - JWT Authentication System

A secure and scalable backend API built with ASP.NET Core for a Smart Transit system.  
This project implements user authentication using JWT (JSON Web Token) with role-based access control.

---

## 🔧 Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- C#

---

## 🚀 Features

- 👤 User Registration
- 🔐 User Login
- 🛡️ JWT Token Generation
- 🔑 Protected API Endpoints
- 👮 Role-based Authorization (User/Admin ready)

---

## 📌 Authentication Flow

1. User registers an account
2. User logs in with email & password
3. Server returns JWT token
4. Token is used to access protected endpoints

---

## 🔐 Example Login Response

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6..."
}
