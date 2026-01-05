# Tag 3: Variablen und Datentypen

## 3.1 Was ist eine Variable?
Programme verwalten, speichern und verarbeiten Daten. Variablen dienen als **platzhalter** im Speicher für diese Informationen.

... (Siehe Merksatz.md für Kurzfassung) ...

## 3.8 Typumwandlung (Konvertierung)

Wenn man Daten verschiedener Typen mischt, muss man sie oft umwandeln.

### 1. Implizite Konvertierung (Automatisch)
*   Funktioniert, wenn **kein Datenverlust** möglich ist.
*   Beispiel: `int` (klein) passt immer in `double` (groß).
*   `int i = 10; double d = i;` -> Erlaubt.

### 2. Explizite Konvertierung (Cast)
*   Nötig, wenn **Datenverlust** möglich ist.
*   Muss dem Compiler erzwungen werden durch `(Zieltyp)Variable`.
*   Beispiel: `double` (groß, mit Komma) in `int` (klein, ohne Komma).
*   `double d = 3.14; int i = (int)d;` -> `i` ist jetzt `3` (Verlust der .14).

## 3.2 Der Variablenname
*   **Grundsatz**: So kurz wie möglich, so aussagekräftig wie nötig.
*   **Konvention**: Typinformation oft als Präfix ("Ungarische Notation").

### Typen-Präfixe (Legacy)
| Datentyp | Präfix |
| :--- | :--- |
| `boolean` | `bln`, `b` |
| `double` | `dbl`, `d` |
| `int` | `int`, `i` |
| `string` | `str`, `s` |
