# Tag 1: Erste Schritte & .NET Framework

## 📚 1.1 & 1.2: Theorie (Das Fundament)
### Warum C#?
*   **Modern & Mächtig**: Von Microsoft entwickelt für alles (Web, Desktop, Cloud, AI).
*   **Typsicher**: Der Compiler hilft dir, Fehler zu vermeiden.
*   **Objektorientiert**: Alles ist ein Objekt (das Hauptziel deiner Ausbildung!).

### Das .NET Framework (WICHTIG!)
Das Herzstück, auf dem C# läuft.
1.  **C# Code** -> wird kompiliert zu -> **IL (Intermediate Language)**.
    *   *Dein Code wird erstmal in eine Zwischensprache übersetzt.*
2.  **CLR (Common Language Runtime)**: Die "Maschine", die dein Programm ausführt.
3.  **JIT (Just-In-Time) Compiler**: Übersetzt IL in echten Maschinencode (010101), den dein spezieller PC versteht.

> **Merke**: Du schreibst C#, der Compiler macht IL, die CLR macht daraus Maschinencode.

## 💻 1.3: Praxis - Hallo .NET
Wir schreiben das klassische "Hallo Welt", achten aber auf Details.

### Code Analyse
```csharp
using System; // Wir nutzen den "System" Namensraum

class Hallo // Eine Klasse (Alles muss in einer Klasse sein)
{
    // Main ist der Einstiegspunkt (Entry Point)
    // static void Main(string[] args)
    static void Main() 
    {
        Console.WriteLine("Hallo .NET Welt!"); // Ausgabe
    }
}
```

### Wichtige Regeln
1.  **Case Sensitivity**: `Console` ist nicht `console`. Groß/Kleinschreibung ist wichtig!
2.  **Klammern {}**: Definieren Blöcke (Wo fängt es an, wo hört es auf?).
3.  **Semikolon ;**: Das Ende eines Befehls.
