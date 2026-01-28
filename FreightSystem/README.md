# 🚛 FreightSystem (Simulated Enterprise Repo)

**Simulating the CargoNerds Backend Environment.**

## 📂 Structure
*   `src/`: **Source Code** (Where the magic happens).
    *   `PricingService/`: The Console App calculating shipping costs.
*   `tests/`: **Verification** (Where we ensure we don't break things).
*   `docs/`: **Knowledge Base** (Architecture, Guides).

## 🚀 How to Run
1.  Open Terminal.
2.  `cd src/PricingService`
3.  `dotnet run`

## 📦 Current Features
*   **Pricing Engine v1.0:** Calculates fees based on Weight.
    *   Rejects over 30,000kg.
    *   Adds Warning Fee for >10,000kg.
