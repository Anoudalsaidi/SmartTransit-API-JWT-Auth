
# 🚆 Smart Transit API

![.NET](https://img.shields.io/badge/.NET-6.0-purple)
![C#](https://img.shields.io/badge/C%23-Programming-blue)
![JWT](https://img.shields.io/badge/JWT-Authentication-orange)
![EF Core](https://img.shields.io/badge/Entity%20Framework-Core-green)
![SQL Server](https://img.shields.io/badge/SQL-Server-red)

---

## 📌 Overview

A secure ASP.NET Core Web API for a Smart Transit system implementing JWT Authentication and Role-Based Authorization.

---

## ✨ Key Features

✔ User Registration  
✔ User Login  
✔ JWT Token Authentication  
✔ Protected API Endpoints  
✔ Role-Based Authorization (User/Admin)

---

## 🎯 Highlights

✔ Real-world JWT Authentication  
✔ Secure API Design  
✔ Clean backend architecture  
✔ Password hashing for security  

---

## 📌 Authentication Flow

1. User registers account  
2. User logs in  
3. JWT token is generated  
4. Token is used to access protected APIs  

---
## 🔐 API Endpoints
### Authentication

POST /api/auth/register

POST /api/auth/login

GET /api/auth/test

## 🔐 Example Response

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6..."
}


