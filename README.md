# ASP.NET Core & Inversion of Control (IoC) Principles

This project demonstrates the **Inversion of Control (IoC) principle** in **ASP.NET Core** by implementing **Dependency Injection (DI)** and best practices for achieving loosely coupled code.

## 📌 Key Concepts

### 1️⃣ **Inversion of Control (IoC) Principle**
IoC is a software design principle where the flow of control is inverted, meaning that objects do not create their dependencies but receive them from an external source.

### 2️⃣ **Dependency Inversion Principle (DIP)**
DIP is one of the SOLID principles that states:
- High-level modules should not depend on low-level modules. Both should depend on abstractions.
- Abstractions should not depend on details; details should depend on abstractions.

### 3️⃣ **Dependency Injection (DI)**
DI is a technique to implement IoC by injecting dependencies into a class rather than creating them inside the class.

### 4️⃣ **Inversion of Control (IoC) Container**
An IoC container is a framework that manages dependencies and provides them when needed. In ASP.NET Core, the built-in **Microsoft.Extensions.DependencyInjection** package serves as an IoC container.

### 5️⃣ **Tightly Coupled Code**
Tightly coupled code directly depends on concrete implementations, making it difficult to modify, test, or scale.

### 6️⃣ **Loosely Coupled Code**
Loosely coupled code depends on abstractions (interfaces), making the application more maintainable and testable.

## 🏗️ Transition from Tightly Coupled to Loosely Coupled Code

1. Identify tightly coupled dependencies in the project.
2. Define interfaces to abstract dependencies.
3. Implement Dependency Injection by registering dependencies in the **IoC container**.
4. Use constructor injection to inject dependencies.

## 🔧 ASP.NET Core IoC Container & Service Lifetimes

### 1️⃣ **Singleton Service**
- Created once and shared across the application.
- Example: Configuration services, logging.

```csharp
services.AddSingleton<IMyService, MyService>();
```

### 2️⃣ **Scoped Service**
- Created once per request (HTTP request scope).
- Example: Database context in web applications.

```csharp
services.AddScoped<IMyService, MyService>();
```

### 3️⃣ **Transient Service**
- Created every time it is requested.
- Example: Lightweight services without shared state.

```csharp
services.AddTransient<IMyService, MyService>();
```

## 🚀 Project Setup

### 1. Clone the Repository
```sh
git clone https://github.com/username/IOC.git
cd IOC
```

### 2. Install Dependencies
```sh
dotnet restore
```

### 3. Run the Application
```sh
dotnet run
```

