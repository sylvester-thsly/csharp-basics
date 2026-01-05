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

## 1.5ie Main-Methode & Blöcke
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

## 1.6 Organisation (Namespace, Class, Method)
Wie C# Code sortiert wird (Hierarchie):
1.  **Namespace (Namensraum)**: Die Schublade. (z.B. `Kap1` oder `System`). Vermeidet Namens-Konflikte.
2.  **Class (Klasse)**: Der Bauplan. (z.B. `CHalloEins` oder `Console`).
3.  **Method (Methode)**: Die Funktion/Aktion. (z.B. `Main` oder `WriteLine`).

### Das `using` Schlüsselwort
*   **Problem**: Ohne `using` muss man immer den vollen Namen schreiben: `System.Console.WriteLine("...")`.
*   **Lösung**: `using System;` erlaubt uns, einfach `Console.WriteLine("...")` zu schreiben.
*   **Regel**: Wenn zwei Namensräume die gleiche Klasse haben (z.B. `System.List` und `MyCode.List`), gibt es einen Fehler. Dann muss man doch den vollen Namen nutzen.

## 1.8 The C# Grammar (Anatomie)
You wanted to know how every C# sentence is built. Here is the translation:

1.  **`namespace Kap1 { ... }`** = **The Book Title**
    *   Everything inside here belongs to the topic "Kap1". It wraps the whole code.
2.  **`using System;`** = **The Dictionary**
    *   Tells the PC: "I am using words from the book 'System'". Without this, it doesn't understand `Console`.
3.  **`class Programm { ... }`** = **The Chapter**
    *   A logical subdivision.
4.  **`static void Main(...) { ... }`** = **"Once upon a time..." (The Start)**
    *   Every story needs a beginning. C# ALWAYS looks for `Main`.
5.  **`;` (Semicolon)** = **The Full Stop.**
    *   Every command MUST end with `;`. Otherwise, the sentence is not finished.
    *   *Error*: `Console.WriteLine("Hallo")` (Wrong) -> `Console.WriteLine("Hallo");` (Right).
6.  **`{ }` (Curly Braces)** = **Paragraphs**
    *   They hold things together that belong together.

## 1.9 Mehrere Main-Methoden (Einstiegspunkt)
Ein Programm kann **mehrere Klassen** haben, und theoretisch kann jede eine `Main`-Methode haben.
*   **Problem**: Der Compiler weiß nicht, wo er starten soll (Welches `Main` ist der Chef?).
*   **Fehler**: `CS0017: Program has more than one entry point defined`.
*   **Lösung**: Man muss dem Compiler den **Einstiegspunkt (Entry Point)** nennen.
    *   *Befehl (Alte Schule/Buch)*: `csc /main:Kap1.CHalloZwei HalloDotNet2.cs`
    *   *Befehl (Modern .NET)*: `dotnet run --property:StartupObject=Kap1.CHalloZwei`

## 1.10 Anatomie einer Fehlermeldung
Wie man Fehler liest (Beispiel `CS0017`):
`HalloDotNet2.cs(7,26): error CS0017: Program has more than one entry point...`

1.  **Wo?** `HalloDotNet2.cs(7,26)`
    *   **Datei**: HalloDotNet2.cs
    *   **Zeile**: 7
    *   **Spalte**: 26 (genaue Zeichenposition)
2.  **Was?** `error CS0017`
    *   Die eindeutige **Fehlernummer**. Man kann danach googeln.
3.  **Warum?** `Program has more than one entry point...`
    *   Die **Beschreibung**.

*   **Tipp**: Doppelklick auf den Fehler im Terminal bringt dich oft direkt zur Zeile.

## 1.11 Case Sensitivity (Groß-/Kleinschreibung)
C# ist **streng**. `Main` ist nicht `main`.
*   **Der Test**: Wenn du `main` (klein) schreibst, findet der Compiler den Startknopf nicht (`error CS1558`).
*   **Merke**: C# unterscheidet penibel zwischen Groß- und Kleinschreibung.

## 1.12 Argumente (`args`)
Der rätselhafte Teil `string[] args`:
*   **Was ist das?** Ein Korb (Array) für Wörter (Strings), die man dem Programm beim Start mitgibt.
*   **Beispiel**: `dotnet run -- Hello`
    *   `args[0]` enthält "Hello".
*   **Index**: Computer zählen ab **0**, nicht ab 1.
    *   1. Wort = `args[0]`
    *   2. Wort = `args[1]`

## 1.13 Workshop (Knowledge Check)
Here are the key questions from the book (Translated):

**Q1: Is it possible to use objects from other languages (like VB.NET) easily in C#?**
*   **A: YES.** Thanks to the .NET Runtime and IL (Intermediate Language), all .NET languages can talk to each other.

**Q2: Is it possible to turn off the Garbage Collector (Memory Management) or manage it yourself?**
*   **A: YES.**
    *   You must use the `unsafe` keyword.
    *   *Advice*: Don't do it unless you really have to. Let .NET handle the trash.
    *   *Example*: `static unsafe void Main()`

**Q3: What is the difference between IL-Code and Machine Code?**
*   **A: The Cooking Process.**
    *   **IL-Code (Intermediate)**: What the C# Compiler creates. It works on ANY computer, but the CPU can't read it yet. (Like a Recipe from the book).
    *   **Machine Code**: What the JIT Compiler creates. It is specific to YOUR CPU (Intel/AMD/ARM). It runs on the metal. (Like the cooked meal).

## 1.14 Quiz & Übungen (Do It Yourself)
**Quiz Answers:**
1.  **Main() vs main()**: `Main` ist der offizielle Einstiegspunkt (Großes M). `main` wird ignoriert.
2.  **Argumente**: Mit **Leerzeichen** (Space). Bsp: `Programm.exe Apfel Birne`.
3.  **Kompilieren (2 Mains)**: Man muss dem Compiler den Eintragungspunkt nennen.
    *   `csc /main:Kap1.CZwei Program.cs` (Buch-Stil)
    *   `dotnet run --property:StartupObject=Kap1.CZwei` (Modern)
     
**Übungen Answers:**
 1.  **Base Framework**: Die riesige Bibliothek (.NET Class Library) + die Runtime (CLR).
2.  **Fehlermeldung**: `Datei(Zeile,Spalte): error ID: Text`.
3.  **CS0017**: "Mehr als ein Main gefunden". Du hast 2 Türen, Windows weiß nicht, welche es nehmen soll.

