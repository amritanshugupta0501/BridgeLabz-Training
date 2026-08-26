# Backend Development Training Program

## Course Overview
This repository outlines the curriculum and project milestones for the training program. The course progresses from foundational database management systems to advanced backend development, culminating in the creation of a persistent console application and the initiation of web-based services.

---

### => Day 1: Database Programming
**Focus:** DBMS Fundamentals & RDBMS Basics

**Core Concepts:**
* Analysis of Database Management Systems (DBMS): Relational vs. Non-Relational structures and standard use cases.
* Introduction to Microsoft SQL Server and Transact-SQL (T-SQL).
* Relational Database Management System (RDBMS) fundamentals, encompassing Data Definition Language (DDL) and Data Manipulation Language (DML).

**Practical Application:**
* Configure and initialize the MS SQL Server development environment.
* Draft the preliminary Entity-Relationship (ER) Diagram for the Health Clinic Application, focusing on core entities (Patients, Doctors, and Appointments).

---

### => Day 2: Database Programming
**Focus:** ER Diagram, Indexing & Normalization

**Core Concepts:**
* Advanced ER Diagram design principles, including entity mapping, relationships, and cardinality.
* Database indexing: Architectural purpose and implications for system performance.
* Data normalization standards (1NF, 2NF, 3NF, and BCNF).

**Practical Application:**
* Finalize the comprehensive ER Diagram for the Health Clinic Application.
* Apply normalization rules to optimize the Patient, Doctor, and Appointment schema.

---

### => Day 3: Database Programming
**Focus:** Joins, Stored Procedures & Triggers

**Core Concepts:**
* Implementation of SQL Joins (Inner, Left, Right, and Full Outer).
* Development and deployment of Stored Procedures for modular data operations.
* Utilization of Triggers for automated, event-driven database actions.

**Practical Application:**
* Script required joins, stored procedures, and triggers to support the application schema (e.g., automating visit history updates).

---

### => Day 4: Database Programming
**Focus:** ADO.NET & Health Clinic App Completion

**Core Concepts:**
* Framework integration: Connecting a .NET application to MS SQL Server utilizing ADO.NET.
* Executing CRUD (Create, Read, Update, Delete) operations via ADO.NET to implement the finalized database schema.

**Practical Application:**
* Complete the Health Clinic Application backend logic to support patient registration, doctor/specialty management, appointment scheduling, visit history tracking, and basic billing processes.
* Ensure all data is reliably persisted via ADO.NET and MS SQL Server.
* Execute a final demonstration of the completed console-based application.

---

### => Day 5: Backend Basics
**Focus:** ASP.NET Core, WebAPI & RESTful Services

**Core Concepts:**
* Introduction to the ASP.NET Core framework and ASP.NET WebAPI architecture.
* Fundamentals of RESTful Services, including standardized design principles and system architecture.

**Practical Application:**
* Scaffold and configure a foundational ASP.NET Core WebAPI project.

---

### => Day 6: Backend Basics
**Focus:** MVC Pattern & REST Request Handling

**Core Concepts:**
* Model-View-Controller (MVC) Pattern.
* C# REST API calls and Request/Response handling.
* HTTP Protocol, Controllers, Routing.

**Practical Application:**
* Build 'My Greetings App' using ASP.NET Core MVC / WebAPI.

---

### => Day 7: Backend Basics
**Focus:** Minimal APIs

**Core Concepts:**
* Minimal APIs in ASP.NET Core - lightweight endpoint definitions.

**Practical Application:**
* Build 'Contacts App' using ASP.NET Minimal Api.

---

### => Day 8: Backend Basics
**Focus:** H2 Database, Distributed Architectures & SDLC Exposure

**Core Concepts:**
* H2 Database and the ADO.NET wrapper (H2Sharp).
* Distributed Architectures - overview and motivation.
* RestAssured.Net for API testing; SDLC exposure.

**Practical Application:**
* Continue Contacts App backend - apply concepts introduced daily in live class.
* Test Contacts App endpoints using RestAssured.Net.

---

### => Day 9: Backend w/ Entity Framework
**Focus:** ORM & Entity Framework Fundamentals

**Core Concepts:**
* ORM concepts; Entity Framework introduction.
* WebAPI-powered REST API with EF.
* Dependency Injection in ASP.NET Core.

**Practical Application:**
* Bootstrap Entity Framework in a new WebAPI project.
* Continue building the Contacts App backend with EF.

---

### => Day 10: Advanced Entity Framework & N-Tier Architecture
**Focus:** Layered Architecture & Generic Design Patterns

**Core Concepts:**
* N-Tier Architecture separation of concerns (Models, Repository, Business, API layers).
* Generic Repository and Generic Service design patterns for code reusability (DRY principles).
* Entity relationships (One-to-One, One-to-Many) and Eager Loading (`.Include()`) in Entity Framework Core.

**Practical Application:**
* Scaffold a multi-layer solution for the Employee Payroll Application.
* Implement a multi-model database context encompassing Departments, Employees, and Salary Profiles.
* Build generic CRUD repositories and strictly typed business services.
* Expose RESTful endpoints using ASP.NET Core WebAPI and test relational data creation via Swagger.

---

### => Day 11: Relational Data Management & Handling Cycles
**Focus:** One-to-Many Relationships & JSON Serialization

**Core Concepts:**
* Implementing One-to-Many entity relationships using foreign keys and navigation properties in Entity Framework Core.

**Practical Application:**
* Develop an N-Tier Address Book Application capable of managing multiple address books and their respective contacts.
* Build custom repositories that extend generic base classes to support complex relational data fetching.
* Configure ASP.NET Core controllers to safely serialize nested relational data and test the endpoints via Swagger.

---

### => Day 12: Advance Backend Development(1)
**Focus:** WebAPI REST Verbs, HttpClient & Action Methods

**Core Concepts:**

* WebAPI REST verbs - GET / POST / PUT / PATCH / DELETE.

* HttpClient for consuming external APIs.

* Action Methods in ASP.NET Core Controllers.

**Practical Application:**

* Fundoo Notes App - User Management Module: user login, registration, password recovery.

---

### => Day 13: Advance Backend Development(2)
**Focus:** Dependency Injection, CORS, Reverse Proxy

**Core Concepts:**

* Dependency Injection deep drive.

* Routing Configuration, Reverse Proxy Concepts.

* Cross-Origin Resource Sharing.

**Practical Application:**

* Fundoo Notes App - Integrated Authentification and Authtorization.

---

### => Day 14: Advance Backend Development(3)
**Focus:** JWT, AuthN vs AuthZ, OAuth & SSO

**Core Concepts:**

* Request/Response - SMD Format.

* JWT Based Authentication.

* AuthN vs AuthZ, OAuth, Single Sign-On(SSO).

**Practical Application:**

* Fundoo Notes App - Notes Module Management.

---

### => Day 15: Advance Backend Development(4)
**Focus:** Entity Framework, CQRS & Linq

**Core Concepts:**

* Command Query Responsibility Segregation design pattern.

* Linq - Advanced Querying.

**Practical Application:**

* Fundoo Notes App - Pin & Archive Module.

---

### => Day 16: Advance Backend Development(5)
**Focus:** Pub-Sub Pattern, Unit Testing, Logging & API Docs

**Core Concepts:**

* Pub-sub pattern for event-driven communication

* Unit Testing with MSTest

* Logging with NLog

* API Testing with Postman; API Documentation with Swagger

**Practical Application:**

* Fundoo Notes App - Tags / Labels Management Module

* Write MSTest unit tests and Swagger docs for existing endpoints

---

### => Day 17: Advance Backend Development(6)
**Focus:** ASP.NET Identity, WebAPI Filters, StyleCop & Session Management

**Core Concepts:**

* ASP.NET Identity — user identity management

* WebAPI Filters, StyleCop for code-style enforcement

* Session Management

**Practical Application:**

* Fundoo Notes App — Reminder & Notification Module

* Queuing via RabbitMQ for asynchronous, non-blocking background processes

---

### => Day 18: Advance Backend Development(7)
**Focus:** REST API Security & Caching

**Core Concepts:**

* Security: REST API Security principles

* Encryption & Decryption; Hashing Algorithms

* Caching with Redis

**Practical Application:**

* Fundoo Notes App — Token Caching via Redis

* Consolidate and harden the full Fundoo Notes App backend

---

### => Day 19: Microservices
**Focus:** Monolith vs Microservices & .NET Microservices Fundamentals

**Core Concepts:**

* Architecture: Monolith vs Microservices – trade-offs

* .NET Microservices – project structure and inter-service communication

**Practical Application:**

* Decomposing the Fundoo Notes App into microservices (User Management, Auth)