# Tag 5: Schleifen (Loops) 🔄

Heute lernen wir, wie man Code wiederholt ausführt, ohne ihn 10x kopieren zu müssen.

## 5.1 Die Typen von Schleifen

### 1. Die `while`-Schleife (Der Standard)
*   **"Kopfgesteuert"**: Prüft die Bedingung **bevor** der Code ausgeführt wird.
*   Ist die Bedingung am Anfang schon `false`, läuft sie **0 Mal**.
```csharp
while (bedingung) { ... }
```

### 2. Die `do-while`-Schleife (Der Türsteher am Ausgang)
*   **"Fußgesteuert"**: Prüft die Bedingung **am Ende**.
*   Läuft garantiert **mindestens 1 Mal**, egal was passiert.
```csharp
do { ... } while (bedingung);
```

### 3. Die `for`-Schleife (Der Zähler)
*   Perfekt, wenn man weiß, **wie oft** etwas passieren soll (z.B. "10 Mal").
*   Format: `for (Start; Bedingung; Schritt)`
```csharp
for (int i = 0; i < 10; i++) { ... }
```

### 4. `goto` (Das Böse 😈)
*   Springt wild im Code herum.
*   **Regel**: Nicht benutzen! Es erzeugt "Spaghetti-Code". (Ausnahme: Manchmal in tief verschachtelten Fehlern).

## 5.2 Steuerung: `break` & `continue`
*   **`break`**: **Abbruch!** Springt sofort komplett aus der Schleife raus.
*   **`continue`**: **Überspringen!** Bricht nur die *aktuelle* Runde ab und macht sofort mit der nächsten weiter.

---
## Praxis:
Wir erstellen ein Projekt, um diese Schleifen zu testen.
