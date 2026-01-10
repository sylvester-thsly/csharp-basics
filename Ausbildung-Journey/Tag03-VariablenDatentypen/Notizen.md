# Tag 3: Variablen und Datentypen

## 3.1 Was ist eine Variable?
Programme verwalten, speichern und verarbeiten Daten. Variablen dienen als **platzhalter** im Speicher.

## 3.5 Elementare Datentypen
Bevor man wählt, muss man wissen, was man braucht. Arbeitsspeicher besteht aus Bytes (8 Bit).

### Bits & Bytes
*   **Bit**: Kleinste Einheit (0 oder 1).
*   **Byte**: 8 Bits. Kann 256 Werte darstellen (2^8).
*   **Integer**: Belegt oft 4 Bytes (32 Bit).

### Die Integer-Familie (Ganzzahlen)
| Typ | Bit | Wertebereich (ca.) | Besonderheit |
| :--- | :--- | :--- | :--- |
| `sbyte` | 8 | -128 bis 127 | Vorzeichenbehaftet |
| `byte` | 8 | 0 bis 255 | Vorzeichenlos (Unsigned) |
| `short` | 16 | -32.768 bis 32.767 | Spart Speicher |
| `ushort` | 16 | 0 bis 65.535 | Unsigned short |
| `int` | 32 | -2 Mrd bis +2 Mrd | Standard für Ganzzahlen |
| `uint` | 32 | 0 bis 4 Mrd | Unsigned int |
| `long` | 64 | Riesig (Trillionen) | Wenn int nicht reicht |
| `ulong` | 64 | Riesig (Positiv) | Unsigned long |

### Die Gleitkomma-Familie (Kommazahlen)
| Typ | Bytes | Genauigkeit | Suffix | Nutzung |
| :--- | :--- | :--- | :--- | :--- |
| `float` | 4 | ~7 Stellen | `f` | Grafik, einfache Berechnungen |
| `double` | 8 | ~15 Stellen | `d` (opt) | Standard für Mathe |
| `decimal`| 16 | ~28 Stellen | `m` | **Finanzen / Geld** (Hohe Genauigkeit) |

> **Achtung "Echtes Literal":** `3.14` ist für C# immer ein `double`.
> `float f = 3.14;` -> Fehler! Muss `3.14f` heißen.
> `decimal m = 3.14;` -> Fehler! Muss `3.14m` heißen.

### Andere Typen
*   **`bool`**: Wahrheitswert (`true` / `false`).
*   **`char`**: Einzelnes Zeichen (`'A'`). Basiert auf Unicode (Zahlencode).

## 3.8 Konvertierung & Sicherheit

### Checked Blocks
Bei expliziter Konvertierung (Cast) von Groß nach Klein werden überzählige Bits einfach abgeschnitten. Das führt zu falschen Zahlen ohne Fehler!
Mit `checked { ... }` kann man erzwingen, dass das Programm abstürzt (Exception), statt falsch weiterzurechnen.

```csharp
checked
{
    sZahl = (short)iZahl; // Wirft Fehler bei Überlauf
}
```

## 3.9 Konstanten
Werte, die sich nie ändern dürfen.
*   **Syntax:** `const int iWoche = 7;`
*   Müssen sofort initialisiert werden.
*   Unterscheidung:
    *   **Literale Konstante:** Die Zahl `5` oder `"Hallo"` im Code.
    *   **Symbolische Konstante:** Der Name `PI`.

## 3.10 Aufzählungen (Enums)
Für Listen von zusammengehörigen Begriffen (Wochentage, Monate, Status).
Ersetzt "Magische Zahlen" (0=Montag, 1=Dienstag...) durch lesbare Namen.

```csharp
enum Woche { Montag=1, Dienstag, Mittwoch, ... }
```
*   Standardmäßig starten sie bei 0.
*   Man kann Startwerte festlegen (`Montag=1`).

## 3.11 Escape-Sequenzen
Sonderzeichen in Strings mit Backslash `\`.
*   `\n`: Neue Zeile
*   `\t`: Tabulator
*   `\"`: Gänsefüßchen im Text speichern
