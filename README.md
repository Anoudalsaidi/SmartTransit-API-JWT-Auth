# 🚆 Smart Transit API

## JWT Authentication System

A simple and secure ASP.NET Core Web API for a Smart Transit system.  
The project demonstrates JWT Authentication and Role-Based Authorization.

---

## 📌 Overview

This project is built to handle user authentication for a transit system using JWT tokens.  
It allows users to register, login, and access protected endpoints securely.

---

## 🔧 Technologies Used

- ASP.NET Core Web API  
- Entity Framework Core  
- SQL Server  
- JWT Authentication  
- C#

---

## 🚀 Features

- User Registration  
- User Login  
- JWT Token Generation  
- Protected API Endpoints  
- Role-Based Authorization (User/Admin)

---

## 🔐 Authentication Flow

1. User registers an account  
2. User logs in with email and password  
3. Server generates JWT token  
4. Token is used to access protected endpoints  

---

## 📡 Example Login Response

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6..."
}
