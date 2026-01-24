# 🍔 The Chef & The Waiter (Frontend vs. Backend)

**Date:** Jan 24, 2026
**Topic:** Why C# is needed for the Web.

## 1. The Question
If HTML/CSS is "The Web", what is C# doing?

## 2. The Restaurant Analogy

### 💁‍♂️ The Frontend (The Waiter)
*   **Technalogies:** HTML, CSS, JavaScript (React, Angular, Vue).
*   **Job:**
    *   Show the Menu (UI).
    *   Take the Order (User Input).
    *   Look nice (Colors, Animations).
*   **Limitation:** The Waiter cannot cook. He cannot save data. He cannot check your bank account.

### 👨‍🍳 The Backend (The Chef -> YOU)
*   **Technologies:** **C#**, Java, Python, Go.
*   **Job:**
    *   Receive the Order (API Request).
    *   Check the Recipe (Business Logic / `if` statements).
    *   Get ingredients from the Fridge (Database).
    *   Cook the meal (Processing).
    *   Give food to the Waiter (Response).

## 3. How it works at CargoNerds 🚛

1.  **User (Frontend):** Clicks "Track Container".
2.  **Frontend:** Sends a message to the Backend: `GET /container/123`.
3.  **Backend (C#):**
    *   `if (user.IsLoggedIn)` (Security Check)
    *   `db.GetContainer("123")` (Database)
    *   `return containerData` (Send JSON back)
4.  **Frontend:** Draws the map and showing the container location.

## 4. Summary
**C#** is the Brains.
**HTML** is the Face.
You are building the **Brain**.
