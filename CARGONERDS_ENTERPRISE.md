# CargoNerds - Enterprise Logistics Platform

## 1. Company Overview
**CargoNerds** (founded 2021, HQ in Hamburg) is a digital logistics provider originally spun off from **Röhlig Logistics**. They focus on providing "Plug-and-Play" digital solutions for small and medium-sized freight forwarders.
*   **Mission**: To digitize global supply chains without requiring massive IT infrastructure or expertise from the client.
*   **Core Philosophy**: "Digital Forwarder" capabilities made accessible.

## 2. Key Product "CN Suite"
The **CargoNerds Suite** is a modular web-based platform that covers the entire lifecycle of a shipment.

### 📦 quoting & Booking
*   **Capabilities**: Real-time rate comparison for Air, Sea, and Road freight.
*   **Integrations**: Direct APIs with major carriers (e.g., Hapag-Lloyd) and aggregators (WebCargo by Freightos, cargo.one).
*   **Workflow**: Users can generate a quote, convert it to a booking, and confirm space with the carrier in minutes.

### 🌍 Tracking & Visibility
*   **Real-Time Tracking**: Milestone-based tracking containers and air freight.
*   **Public Links**: "No-Login" tracking links that can be shared with end-customers (similar to Amazon/DHL tracking).
*   **Supply Chain Visibility**: Integration with providers like **FourKites** for predictive ETA and delay alerts.

### 📊 Analytics & Reporting
*   **Dashboard**: Customizable widget-based view of KPIs (Volume moved, Spend, Carrier performance).
*   **Sustainability**: **CO2 Calculator** (compliant with GLEC frameowrk) to measure emissions per shipment leg. This is a major selling point for ESG compliance.

### 📄 Digital Documents
*   **e-Docs**: Management of Bills of Lading (BoL), Invoices, and Packing Lists.
*   **Automation**: Automated generation of customer-facing documents to reduce manual entry.

## 3. Technical Architecture

### ☁️ Cloud & Infrastructure
*   **Hosting**: Cloud-native architecture (likely AWS or Azure), ensuring high availability and scalability.
*   **Security**: Compliance with European Data Protection (GDPR) standards.

### 🔌 Connectivity (The "Nerds" Part)
*   **API-First Design**: The platform is built to talk to other systems. It sits "on top" of traditional TMS (Transportation Management Systems) like **Magaya** or **Cargowise**.
*   **Data Exchange**:
    *   **Inbound**: Pulls data from carriers, TMS, and IoT devices.
    *   **Outbound**: Pushes updates to customer portals and ERP systems.

## 4. Why it matters (For our Simulation)
Our "LogisticsOS" simulation captures the *spirit* of CargoNerds by focusing on:
1.  **The Live Feed**: Mimicking the real-time data ingestion from carriers.
2.  **CO2 Calculation**: Replicating their sustainability reporting features.
3.  **Command Center**: The "Dashboard" feel reflects the centralized control CargoNerds gives to freight forwarders.
