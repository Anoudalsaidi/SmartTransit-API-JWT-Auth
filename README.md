# 🚆 Smart Transit API

![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![C#](https://img.shields.io/badge/C%23-Programming-blue)
![JWT](https://img.shields.io/badge/JWT-Authentication-orange)
![EF Core](https://img.shields.io/badge/Entity%20Framework-Core-green)
![SQL Server](https://img.shields.io/badge/SQL-Server-red)

## 📌 Overview

Smart Transit API is a secure ASP.NET Core Web API that demonstrates modern authentication and authorization practices using JWT (JSON Web Tokens).

The project allows users to register, log in securely, receive JWT tokens, and access protected endpoints based on authentication status.

---

## 🚀 Features

* 👤 User Registration
* 🔐 Secure User Login
* 🛡️ JWT Token Generation
* 🔑 Protected API Endpoints
* 👮 Role-Based Authorization
* 🔒 Password Hashing with ASP.NET Identity
* 💾 SQL Server Integration with Entity Framework Core

---

## 🎯 Highlights

✔ JWT Authentication & Authorization

✔ Secure Password Hashing

✔ RESTful API Design

✔ Entity Framework Core Integration

✔ Clean and Scalable Backend Structure

---

## 🔄 Authentication Flow

1. User creates an account.
2. Password is securely hashed before storage.
3. User logs in using email and password.
4. JWT token is generated and returned.
5. Token is included in the Authorization header.
6. Protected endpoints validate the token before granting access.

---

## 🔐 API Endpoints

### Authentication

| Method | Endpoint             | Description                        |
| ------ | -------------------- | ---------------------------------- |
| POST   | `/api/auth/register` | Register a new user                |
| POST   | `/api/auth/login`    | Authenticate user and generate JWT |
| GET    | `/api/auth/test`     | Protected endpoint                 |

---

## 📥 Example Login Request

```json
{
  "email": "user@example.com",
  "password": "password123"
}
```

## 📤 Example Login Response

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6..."
}
```

---

## 🔒 Accessing Protected Endpoints

```http
GET /api/auth/test
Authorization: Bearer YOUR_TOKEN
```

### Response

```text
You are authorized!
```

---

## 🛠️ Tech Stack

* ASP.NET Core Web API
* C#
* Entity Framework Core
* SQL Server
* JWT Authentication
* ASP.NET Identity Password Hasher

---

## ⚙️ Getting Started

```bash
git clone https://github.com/Anoudalsaidi/SmartTransit-API-JWT-Auth.git
```

```bash
dotnet ef database update
```

```bash
dotnet run
```

---

## 📚 What I Learned

* Implementing JWT Authentication
* Securing APIs using Bearer Tokens
* Password Hashing and Verification
* Role-Based Authorization
* Entity Framework Core Integration
* Building Secure REST APIs

---

## 👩‍💻 Author

**Anoud Alsaidi**

Backend Developer | ASP.NET Core | SQL Server | JWT Authentication
