# 🛒 Scalable E-Commerce Backend (.NET)

A **production-style backend system** built with **ASP.NET Core**, following clean architecture principles and modern backend practices such as **JWT authentication, Redis caching, password hashing, and repository pattern**.

This project demonstrates how to design a **secure, scalable and maintainable backend API** similar to real-world enterprise systems.

---

# 🚀 Tech Stack

**Backend Framework**

* ASP.NET Core Web API (.NET)
* Entity Framework Core
* SQL Server

**Security**

* JWT Authentication
* Role-Based Authorization
* BCrypt Password Hashing

**Caching**

* Redis Distributed Cache

**Architecture**

* Clean Architecture
* Repository Pattern
* Dependency Injection

**API Documentation**

* Swagger / OpenAPI

---

# 🏗 Architecture

The project follows a **Clean Architecture** structure to ensure separation of concerns and maintainability.

```
EcommerceSystem
│
├── Ecommerce.API
│   ├── Controllers
│   ├── Program.cs
│
├── Ecommerce.Application
│   ├── Interfaces
│
├── Ecommerce.Domain
│   ├── Entities
│
├── Ecommerce.Infrastructure
│   ├── Persistence
│   ├── Repositories
```

### Layer Responsibilities

**Domain**

* Core business entities
* Business rules

**Application**

* Interfaces
* Business logic contracts

**Infrastructure**

* Database access
* Repository implementations

**API**

* Controllers
* Authentication
* Middleware
* API endpoints

---

# 🔐 Authentication & Security

This API uses **JWT (JSON Web Token)** authentication.

Workflow:

```
User Register
     ↓
Password hashed with BCrypt
     ↓
Stored securely in database
     ↓
User Login
     ↓
JWT Token generated
     ↓
Client sends token in Authorization header
```

Example header:

```
Authorization: Bearer <JWT_TOKEN>
```

---

# ⚡ Redis Caching

Redis is used to **cache frequently accessed data** such as product lists.

Benefits:

* Reduces database load
* Improves API response time
* Enables distributed caching across services

Cache strategy used:

```
GET /products
    ↓
Check Redis Cache
    ↓
Cache miss → Fetch from DB
    ↓
Store in Redis
```

Cache invalidation occurs when:

* Product created
* Product updated
* Product deleted

---

# 📦 Features

✔ Product CRUD APIs
✔ Secure user authentication
✔ JWT token generation
✔ Role-based authorization
✔ Password hashing with BCrypt
✔ Redis distributed caching
✔ Clean architecture implementation
✔ Repository pattern
✔ Swagger API documentation

---

# 🧪 API Testing

You can test APIs using:

* Swagger UI
* Postman
* Curl

Swagger available at:

```
http://localhost:5270/swagger
```

---

# ⚙ Setup & Installation

### 1️⃣ Clone Repository

```
git clone https://github.com/yourusername/Scalable-Ecommerce-Backend.git
```

---

### 2️⃣ Navigate to Project

```
cd EcommerceSystem
```

---

### 3️⃣ Install Dependencies

```
dotnet restore
```

---

### 4️⃣ Apply Database Migration

```
dotnet ef database update
```

---

### 5️⃣ Run Application

```
dotnet run
```

---

# 🧠 Concepts Demonstrated

This project demonstrates several **backend engineering concepts**:

* Clean Architecture
* REST API design
* Authentication & Authorization
* Secure password storage
* Caching strategies
* Dependency Injection
* Database migrations
* Repository Pattern

---

# 🚀 Future Improvements

Planned enhancements:

* Background job processing
* Docker containerization
* Message queue (Kafka / RabbitMQ)
* Global exception middleware
* API rate limiting
* Logging with Serilog
* CI/CD pipeline

---

# 📚 Learning Purpose

This project was built as a **learning exercise to understand modern backend system design** and demonstrate industry practices in .NET backend development.

---

# 👨‍💻 Author

**Devesh Kumar Upadhyay**

Backend Developer | .NET Core | ASP.NET Core

---

# ⭐ Support

If you found this project useful, consider giving it a **star ⭐ on GitHub**.
