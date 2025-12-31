# 📝 Notizen: Tag 1 - Erste Schritte & .NET Framework

*Basierend auf dem Lehrbuch.*

## 1.1 Warum C#?
*   **Historie**: Aus C/C++ entstanden, aber neu für .NET entwickelt.
*   **Vorteile**:
    *   **Typsicher**: Compiler verhindert Fehler.
    *   **Komponentenbasiert**: Wiederverwendbare Bausteine (spart Zeit).
    *   **Mischung**: Performance von C++ + Einfachheit von Visual Basic.
*   **Ziel**: Die Hauptsprache für die .NET-Plattform.

## 1.2 Das .NET Framework
Das Fundament, auf dem alles läuft.
### 3 Hauptteile:
1.  **.NET Framework** (CLR + Klassenbibliotheken)
2.  **Web Services** (ASP.NET)
3.  **Enterprise Server**

### Wie es funktioniert (WICHTIG für Prüfung!)
1.  **Source Code (C#)**: Was du schreibst.
2.  **Compiler (csc.exe)**: Macht daraus **IL-Code** (Intermediate Language).
    *   *Merkspruch*: "Eine Sprache für alle." Egal ob C# oder VB.NET, am Ende ist alles IL.
3.  **CLR (Common Language Runtime)**: Die "Managerin".
    *   Verwaltet Speicher (**Garbage Collector** - die Müllabfuhr für Daten).
    *   Sorgt für Sicherheit.
    *   Führt den Code aus.
4.  **JIT (Just-In-Time) Compiler**:
    *   Übersetzt IL-Code in **Native Code** (Maschinensprache für deinen PC).
    *   Passiert "Just in Time" (genau im Moment des Aufrufs).

> **Managed Code**: Code, der von der CLR verwaltet wird (Sicher & Automatische Speicherbereinigung).

## 1.3 Eine Klasse für sich (OOP)
### Die Analogie: Das Skript
*   **Klasse (Class)** = Das **Original-Skript** des Professors.
    *   Es gibt nur Eines. Es ist der Bauplan.
*   **Objekt (Object)** = Die **Kopie** des Studenten.
    *   Jeder Student hat seine eigene Kopie (Instanz).
    *   Wenn Student A etwas reinschreibt, ändert sich nichts bei Student B.

### Programm-Beispiel
*   **Klasse**: `Student` (Eigenschaften: Haarfarbe, Größe)
*   **Objekt**: `Shinja` (ist eine Instanz von Student)
*   **Punkt-Notation**: `Shinja.Haarfarbe = schwarz`
    *   Der Punkt `.` greift auf Eigenschaften zu (wie ein Pfad `C:\Dateien`).

## 1.4 Praxis-Vorbereitung
Um Programmieren zu lernen, muss man:
1.  Den Editor kennen (Visual Studio / VS Code).
2.  Den Compiler verstehen.
3.  Fehlermeldungen lesen lernen.

## 1.5 Kommentare
Kommentare erklären den Code und werden vom Compiler ignoriert.
*   **Einzeilig**: `//` (Alles danach ist Kommentar).
*   **Mehrzeilig**: `/*` ... `*/` (Kann über mehrere Zeilen gehen).
*   **Best Practice**: Kommentiere Code, der nicht sofort verständlich ist ("Warum" statt "Was"). lieber zu viel als zu wenig.

## 1.6 Die Main-Methode & Blöcke
Code wird in **Blöcke** `{ ... }` unterteilt, um ihn lesbar zu machen. Man *könnte* alles in eine Zeile schreiben, aber das macht niemand.

### Zerlegung von `Main`
`public static void Main(string[] args)`

*   **public**: Öffentlich. Jeder darf auf diese Methode zugreifen.
*   **static**: Statisch. Man braucht kein Objekt (keine Instanz) der Klasse, um sie aufzurufen. Sie ist "einfach da".
*   **void**: Leer. Die Methode gibt **kein Ergebnis** zurück (keine Zahl, keinen Text).
    *   *Warum?* `void` Methoden sind "Macher", keine "Rechner". Sie tun etwas (z.B. Drucken auf den Bildschirm), aber sie geben dem PC keine Antwort zurück.
    *   *Analogie*:
        *   **Nicht-Void**: "Chef, wie viele Eier sind da?" -> Antwort: "5".
        *   **Void**: "Chef, koche das Essen!" -> Antwort: (Stille, aber das Essen wird gekocht).
    *   *Alternative*: `int` (Ganzzahl) ist auch erlaubt, wird aber seltener genutzt.
*   **Main**: Der Name des Chefs. Hier startet das Programm.
*   **string[] args**: Übergabewerte (Argumente) beim Start des Programms.
