# Syncline Chat Application

A **real-time chat application** built with **ASP.NET Core**, **SignalR**, and **Entity Framework Core**.  
The project is designed with a clean architecture to separate concerns between domain, application, persistence, and API layers.

---

## 📂 Project Structure

- **Syncline.Domain**  
  Contains core entities and interfaces:
  - `Entities/ChatMessage.cs` – Chat message model
  - `Interfaces/IMessageRepository.cs` – Message repository interface
  - `Interfaces/IMessageService.cs` – Message service interface
  - `Interfaces/IRoomRepository.cs` – Room repository interface

- **Syncline.Persistence**  
  Handles database access:
  - `Context/SynclineDbContext.cs` – EF Core DbContext
  - `Repositories/MessageRepository.cs` – Implementation for message data access
  - `Migrations/` – Database migration files

- **Syncline.Application**  
  Contains business logic and services:
  - `Services/MessageService.cs` – Logic for creating and managing messages

- **Syncline.Api**  
  Web API and SignalR hub:
  - `Hubs/ChatHub.cs` – SignalR hub for sending/receiving messages
  - `Program.cs` – Service registration and app configuration

---

## ⚡ Features

- Join chat rooms in real-time
- Send and receive messages with SignalR
- Persist messages in **PostgreSQL**
- Clean, layered architecture

---

## 🛠 Installation & Run

1. Clone the repository:

```bash
git clone <repository-url>
cd Syncline
```
2. Configure your PostgreSQL connection string in Syncline.Api/appsettings.json
3. Apply database migrations: 

```bash
cd Syncline.Persistence
dotnet ef database update -s ../Syncline.Api
```

4. Run the API:

```bash
cd ../Syncline.Api
dotnet run
```

5. SignalR Hub URL:

``` bash 
https://localhost:5001/chathub
```

# 📌 Architecture

Domain Layer – Entities and interfaces

Application Layer – Business logic

Persistence Layer – Database access

API Layer – Web API & SignalR hub