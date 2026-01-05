# Tag 2: Visual Studio & IDE

## 2.1 Einführung: Die Entwicklungsumgebung (IDE)
Das Buch sagt: BASICs (`csc.exe` + Editor) reichen für den Anfang.
**ABER**: Sobald es kompliziert wird (**"Umfangreicher und komplexer"** oder **"Grafische Oberflächen"**), wird es mühsam.

**Lösung**: Eine **IDE** (Integrierte Entwicklungsumgebung) wie **Visual Studio**.

### Was lernen wir heute?
1.  Was ist eine IDE?
2.  Wie erstellt man Programme damit?
3.  Wie funktioniert die **Projektverwaltung**?
4.  Was ist **Debug** vs **Release**?

## 2.3 Projekt erstellen (Workflow)
Das Buch beschreibt den Weg im alten Visual Studio ("Datei -> Neu -> Projekt").
Bei uns in **VS Code** geht das so:

**A. Der Moderne Weg (Terminal - wie Profis):**
1.  Terminal öffnen.
2.  `dotnet new console -o MeinProjektName`
3.  `code MeinProjektName` (Öffnet den Ordner).

**B. Der Editor Weg (VS Code):**
*   Man öffnet einen leeren Ordner.
*   Terminal -> `dotnet run` reicht oft nicht, man braucht eine Projektdatei (`.csproj`).
*   VS Code fragt oft: "Required assets to build and debug are missing. Add them? -> Yes". (Das ist wichtig fürs Debuggen!).

### Schritte laut Buch (angepasst auf uns):
1.  **Projekt anlegen**: Wir erstellen `Tag02-Projekt`.
2.  **Quelltext aufsetzen**: `Program.cs` bearbeiten.
3.  **Kompilieren**: In VS Code drücken wir oft einfach **F5** (Start Debugging) oder tippen `dotnet run`.

> **Hinweis:** Das Buch nutzt `namespace Kap2`. Das übernehmen wir.

## 2.4 Dateien & Projektmappen
Das Buch erklärt die Dateistruktur:
*   **`.csproj` (Projektdatei)**: Die "Bauanleitung" im XML-Format. Beinhaltet Infos, welche Dateien dazu gehören.
*   **`.sln` (Solution/Projektmappe)**: Ein Karton für **mehrere** Projekte. (Brauchen wir am Anfang selten, ist aber gut zu wissen).

## 2.5 Der "Explorer"
Im Buch heißt er "Projektmappen-Explorer".
In **VS Code** ist es einfach der **Explorer** (linke Seitenleiste).
*   Hier siehst du alle Dateien.
*   Hier kannst du Dateien löschen, umbenennen oder öffnen.

## 2.6 Starten & Debuggen (Shortcuts)
Der wichtigste Unterschied:
1.  **Starten ohne Debuggen** (Nur Ausführen):
    *   **Buch**: `Strg + F5` (Fenster bleibt offen).
    *   **VS Code (Terminal)**: `dotnet run`.
2.  **Starten MIT Debuggen** (Fehlersuche):
    *   **Buch**: `F5` (Fenster geht oft sofort zu nach Ende).
    *   **VS Code**: `F5` (Startet den Debugger-Modus).

---
**Praxis-Check:**

---

## 2.7 Praxis-Übung: Projektverwaltung mit CLI

Wir haben heute die Projektverwaltung in der Konsole geübt.
Im Gegensatz zum alten Visual Studio müssen wir Dateien nicht explizit "Hinzufügen".
**VS Code / .NET CLI** scannt den Ordner automatisch!

### Unsere Übungsschritte:
1.  **Solution erstellen** (Container für mehrere Projekte):
    ```bash
    dotnet new sln -n Tag02
    ```
2.  **Projekt hinzufügen**:
    ```bash
    dotnet sln add HalloVisual/HalloVisual.csproj
    ```
3.  **Dateien austauschen** (Beispiel aus dem Buch):
    *   Wir haben ein neues Projekt `BeispielProjekt` erstellt.
    *   Wir haben `Program.cs` gelöscht (`rm Program.cs`).
    *   Wir haben eine externe Datei `BeispielSource.cs` hineinkopiert.
    *   **Ergebnis**: `dotnet run` hat sie sofort erkannt und ausgeführt!

> **Wichtig**: Alles was im Ordner liegt und auf `.cs` endet, wird kompiliert. Man muss es nicht extra in einer Liste eintragen (Globbing).
