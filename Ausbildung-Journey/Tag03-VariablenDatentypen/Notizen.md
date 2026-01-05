# Tag 3: Variablen und Datentypen

## 3.1 Was ist eine Variable?
Programme verwalten, speichern und verarbeiten Daten. Variablen dienen als **platzhalter** im Speicher für diese Informationen.

Drei Aspekte sind bei Variablen wichtig:
1.  **Typ der Variablen**:
    *   Legt die Größe des reservierten Speichers fest.
    *   Bestimmt Art und Weise der Daten (Validierung).
    *   Typensicherheit: `int` kann nur Ganzzahlen speichern, keine `3.14` (double).
    *   Implizite Konvertierung kann fehlschlagen (z.B. double zu int).
2.  **Gespeicherte Daten**:
    *   Müssen zum Typ passen.
    *   C# ist streng typisiert: `314.0` wird als double interpretiert und passt nicht in `int`.
3.  **Name der Variablen**:
    *   Identifiziert den Speicherbereich.
    *   Erlaubt: Buchstaben, Zahlen, `_`.
    *   Start: Buchstabe oder `_`.

## 3.2 Der Variablenname
*   **Grundsatz**: So kurz wie möglich, so aussagekräftig wie nötig.
*   **Konvention**: Typinformation oft als Präfix ("Ungarische Notation" / Legacy-Stil, aber hier im Lehrmaterial erwähnt).

### Typen-Präfixe (Tabelle 3.1)
| Datentyp | Präfix (Beispiele) |
| :--- | :--- |
| `boolean` | `bln`, `b` (bAnrede) |
| `byte` | `byt`, `bt` (btMonat) |
| `sbyte` | `sbyt`, `sbt` (sbtWoche) |
| `double` | `dbl`, `d` (dWaehrung) |
| `int` | `int`, `i` (iAlter) |
| `long` | `lng`, `l` (lSekunden) |
| `object` | `obj`, `o` (oMyObject) |

*   **Vermeidung**: Namen, die sich nur durch Groß-/Kleinschreibung unterscheiden (z.B. `iMwSt` vs `iMWST`).
