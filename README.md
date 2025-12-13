<div align="center">

# 🚀 LogisticsOS - C# Learning Project

### *Building a Full-Stack Logistics Simulation from Scratch*

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![React](https://img.shields.io/badge/React-61DAFB?style=for-the-badge&logo=react&logoColor=black)
![SQLite](https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white)
![Status](https://img.shields.io/badge/Status-Active-brightgreen?style=for-the-badge)

</div>

---

## 🎯 Mission

Learning C# by building a **real-world logistics platform** inspired by CargoNerds, preparing for my **IT Ausbildung** starting August 2026.

**Currently 16 years old**, transforming theory into production-ready code in Hamburg, Germany 🇩🇪

---

## 🏗️ What is LogisticsOS?

A full-stack web application that simulates a logistics operations center with:
- **Real-time CO2 emission calculations** for shipments
- **Live feed** with syslog-style activity monitoring
- **TOTP-based security** (Google Authenticator integration)
- **Interactive CLI** for system control
- **Background simulation engine** for traffic generation
- **SQLite database** for persistent storage

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| **Backend** | ASP.NET Core 8 (C#) |
| **Database** | SQLite + Entity Framework Core |
| **Frontend** | React 18 (CDN), TailwindCSS |
| **Security** | Custom TOTP (jsSHA) |
| **Animations** | Framer Motion |
| **Version Control** | Git & GitHub |
| **IDE** | Visual Studio Code |

---

## ✨ Features Implemented

### ✅ Phase 1: Foundation (Completed)
- [x] ASP.NET Core Web API setup
- [x] SQLite database with EF Core migrations
- [x] RESTful API endpoints (`/api/emissions/calculate`, `/api/emissions/history`)
- [x] CO2 emission calculation engine
- [x] Static file serving for SPA

### ✅ Phase 2: Frontend & UX (Completed)
- [x] React-based dashboard with client-side routing
- [x] Terminal-style Live Feed with real-time polling
- [x] Animated log stream (syslog format)
- [x] Responsive design with glassmorphism effects

### ✅ Phase 3: Security & Interactivity (Completed)
- [x] TOTP verification screen (Google Authenticator)
- [x] Native JavaScript TOTP implementation
- [x] QR code generation for device setup
- [x] Interactive CLI with commands (`help`, `status`, `clear`, `sim start`, `sim stop`)
- [x] Background traffic simulator

### 🔄 Phase 4: Advanced Features (In Progress)
- [x] Priority shipping flag (Database schema update)
- [ ] Priority visualization in Live Feed
- [ ] Flight tracker with interactive world map
- [ ] Real-time analytics widgets
- [ ] System boot sequence animation

---

## 📂 Project Structure

```
CargonerdsSimulation/
├── Cargonerds.API/          # ASP.NET Core Web API
│   ├── Controllers/         # API endpoints
│   ├── Data/               # Database context & models
│   ├── Migrations/         # EF Core migrations
│   ├── wwwroot/            # Static files (React app)
│   └── Program.cs          # App configuration
├── Cargonerds.Core/        # Business logic
│   └── EmissionCalculator.cs
├── SYSTEM_OVERVIEW.md      # Technical documentation
├── CARGONERDS_ENTERPRISE.md # Real-world inspiration
└── LEARN_CSHARP_LESSON_1.md # Learning notes
```

---

## 🎮 Key Learning Milestones

### 🟢 C# Fundamentals Mastered
- ✅ Variables, Types, and Properties (`public int Id { get; set; }`)
- ✅ Classes and Objects (OOP basics)
- ✅ Methods and Return Types
- ✅ Async/Await patterns
- ✅ Dependency Injection
- ✅ LINQ queries

### 🟡 Database & Backend
- ✅ Entity Framework Core setup
- ✅ Database migrations
- ✅ RESTful API design
- ✅ CORS configuration
- ✅ Static file middleware

### 🔵 Full-Stack Integration
- ✅ React state management (`useState`, `useEffect`)
- ✅ API polling and data fetching
- ✅ Client-side routing
- ✅ Real-time UI updates

---

## 📊 Progress Stats

```text
⏰ Total Development Time  : ~6 hours
📝 C# Concepts Learned     : 15+
🎯 Features Built          : 12
🔥 GitHub Commits          : 2
📅 Days Until Ausbildung   : 597 days
💪 Confidence Level        : Growing 📈
```

---

## 🚀 Quick Start

### Prerequisites
- .NET 8 SDK
- Node.js (for npm packages)

### Run Locally
```bash
# Clone the repository
git clone https://github.com/sylvester-thsly/csharp-basics.git
cd csharp-basics

# Run the application
dotnet run --project Cargonerds.API --launch-profile http

# Open browser
http://localhost:5100

# Access Code (Google Authenticator)
Secret: KVKFKRCPNZQUYMLX
```

### CLI Commands (In Live Feed)
```bash
help        # List all commands
status      # System status
sim start   # Start traffic simulation
sim stop    # Stop simulation
clear       # Clear logs
reboot      # Reload page
```

---

## 🎓 What I Learned Today (Dec 13, 2024)

### Morning Session
- How to structure a C# Web API project
- Database schema design with Entity Framework
- API endpoint creation and testing

### Afternoon Session
- Properties vs. Fields in C#
- Database migrations workflow
- Git merge conflict resolution
- Full-stack feature implementation (Priority Flag)

### Key Takeaway
> *"90% of coding is just simple logic like 'if this, then that'. It's not magic; it's just instructions."*

---

## � Next Steps

1. **Complete Priority Feature** - Add visual indicators in Live Feed
2. **Flight Tracker** - Build interactive world map with shipment arcs
3. **System Boot Sequence** - BIOS-style loading animation
4. **Deploy to Azure** - Learn cloud hosting
5. **Unit Tests** - Write tests for EmissionCalculator

---

## 💪 Why This Approach Works

Instead of following generic tutorials, I'm building a **real product** inspired by the company I'll join (CargoNerds). This means:
- ✅ Learning by doing, not just reading
- ✅ Building portfolio-worthy projects
- ✅ Understanding how enterprise software works
- ✅ Gaining confidence through tangible results

---

## 📚 Resources I'm Using

- � [Microsoft C# Documentation](https://learn.microsoft.com/dotnet/csharp/)
- � [ASP.NET Core Tutorial](https://learn.microsoft.com/aspnet/core/)
- 🧠 AI Pair Programming (Antigravity by Google DeepMind)
- � [CargoNerds Platform](https://cargonerds.com) (Inspiration)

---

## 📫 Connect

[![GitHub](https://img.shields.io/badge/GitHub-sylvester--thsly-181717?style=for-the-badge&logo=github)](https://github.com/sylvester-thsly)

---

<div align="center">

### 🔥 *From Zero to Full-Stack in One Day* 🔥

**Last Updated:** December 13, 2024

![Visitor Count](https://visitor-badge.laobi.icu/badge?page_id=sylvester-thsly.csharp-basics)

</div>
