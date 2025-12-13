# LogisticsOS (formerly Cargonerds Simulation) - System Overview

## 1. High-Level Architecture
LogisticsOS is a modern, web-based simulation platform designed to visualize and calculate logistics emissions. It is built using a **Split-Stack Architecture**:

*   **Frontend**: Single Page Application (SPA) built with **React**, **TailwindCSS**, and **Framer Motion**. It is served statically by the .NET backend but runs entirely in the user's browser (Client-Side).
*   **Backend**: **ASP.NET Core 8 Web API**. It acts as the "Engine" (Logic Layer) processing calculations and managing data.
*   **Database**: **SQLite**. A lightweight, file-based relational database (`cargonerds.db`) that persists shipment history.

---

## 2. Key Components

### 🖥️ Frontend (Client-Side)
The user interface is a "Terminal/Dashboard" style application designed for high interactivity and visual immersion.
*   **Location**: `wwwroot/index.html` (All-in-One file for simplicity in this proto-phase).
*   **Core Libraries**:
    *   `React 18` & `ReactDOM`: UI Component structure.
    *   `TailwindCSS` (CDN): rapid styling.
    *   `Framer Motion` (CDN): Animations (page transitions, logging effects).
    *   `Lucide Icons`: Visual iconography.
    *   `jsSHA`: **Native TOTP Security** engine (Zero-dependency implementation).
*   **Key Features**:
    1.  **Security Gate**: A TOTP-based (Google Authenticator) lock screen preventing unauthorized access. Uses a custom-built, tolerance-enabled verification algorithm.
    2.  **CLI (Command Line Interface)**: A functional terminal allowing users to run commands like `sim start`, `status`, and `clear`.
    3.  **Live Feed**: A simulated "syslog" view that polls the backend API for real-time shipment events.
    4.  **Simulation Engine**: A background Javascript interval that generates random shipment data and `POST`s it to the API to simulate traffic.

### ⚙️ Backend (Server-Side)
The "Brain" of the operation.
*   **Framework**: .NET 8 (C#).
*   **Entry Point**: `Program.cs`. Configured to serve static files (the React app) and Map API controllers.
*   **Controller**: `EmissionsController.cs`.
    *   `GET /api/emissions/history`: Used by the Frontend Live Feed to fetch the latest activity.
    *   `POST /api/emissions/calculate`: Accepts `Distance` and `Weight`, calculates CO2, and saves to DB.
*   **Core Logic**: `EmissionCalculator.cs`.
    *   Formula: `CO2 = Distance (km) * Weight (kg) * 0.002`.
    *   Rating System: returns "Eco-Friendly", "Standard", or "Heavy Impact" based on thresholds.

### 💾 Database (Persistence)
*   **Technology**: SQLite with Entity Framework Core.
*   **File**: `cargonerds.db` (Located in the root execution folder).
*   **Schema**:
    *   `Id` (Primary Key)
    *   `DistanceKm` (Double)
    *   `WeightKg` (Double)
    *   `Co2Emission` (Double)
    *   `CreatedAt` (DateTime)

---

## 3. Data Flow Example: "Simulation Start"

1.  **User Action**: User types `sim start` in the CLI.
2.  **Frontend Logic**: The React app starts a Javascript Interval (e.g., every 3 seconds).
3.  **Data Generation**: The frontend generates a random shipment (e.g., 500km, 2000kg).
4.  **API Request**: Frontend sends a `POST` request to `/api/emissions/calculate` with this data.
5.  **Backend Processing**:
    *   Validation: Checks if numbers are positive.
    *   Calculation: `EmissionCalculator` computes the CO2 output.
    *   Persistence: The record is saved to `cargonerds.db` via EF Core.
6.  **Response**: Backend sends back the calculated CO2 and the Database ID.
7.  **Visual Feedback**:
    *   The frontend receives the "OK".
    *   The Live Feed polls `/api/emissions/history` and immediately displays the new log entry with a "SUCCESS" tag.

## 4. Security Implementation
The system uses a **Client-Side TOTP (Time-Based One-Time Password)** implementation.
*   **Secret**: `KVKFKRCPNZQUYMLX` (Hardcoded for demo, but secure in principle).
*   **Algorithm**: HMAC-SHA1 (RFC 6238).
*   **Implementation**: Custom JavaScript function using `jsSHA` to perform the hashing and bit-shifting required to generate the 6-digit code.
*   **Drift Tolerance**: Configured to match strict time windows (Current Epoch) for high security, with debug logs available in the browser console.
