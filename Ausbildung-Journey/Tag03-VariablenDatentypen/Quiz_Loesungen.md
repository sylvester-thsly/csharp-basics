# Tag 3: Workshop Lösungen

## Quiz

**1. Welche Variablennamen sind zulässig?**
*   `7Tage`: **Nein** (Darf nicht mit Zahl beginnen).
*   `_specialOrder`: **Ja** (Unterstrich am Anfang erlaubt).
*   `Postleitzahl`: **Ja**.
*   `Eingang.Daten`: **Nein** (Punkt nicht erlaubt).
*   `Ausgang_Daten`: **Ja**.
*   `decimal`: **Nein** (Reserviertes Schlüsselwort).
*   `Bez Name`: **Nein** (Leerzeichen nicht erlaubt).
*   `Fläche`: **Ja** (Umlaute theoretisch erlaubt, aber unüblich/nicht empfohlen in englischem Code).

**2. Welche Deklarationen sind zulässig?**
*   `int 123;`: **Nein** (Variablenname kann keine Zahl sein).
*   `char Buchstabe;`: **Ja**.
*   `long lZahl1, lZahl2;`: **Ja**.
*   `int iZahl1, long iZahl2;`: **Nein** (Verschiedene Typen in einer Zeile nicht erlaubt; Komma trennt gleiche Typen).
*   `bool bWahl1 bWahl2;`: **Nein** (Komma fehlt).
*   `short Arg = 7 + 7;`: **Ja** (Berechnung bei Initialisierung erlaubt).

**3. Wird folgendes Listing ausgeführt?**
```csharp
int iZahl = 0;
string sAlter = "27 Jahre";
iZahl = Convert.ToInt32(sAlter);
Console.WriteLine(iZahl);
```
**Antwort:** Es wird kompiliert, aber gibt zur **Laufzeit einen Fehler (Exception)**. `Convert.ToInt32` kann "27 Jahre" nicht parsen, da Buchstaben enthalten sind.

## Übungen

**1. Datentypen Wahl:**
*   `Vorname`: `string`
*   `Alter`: `byte` (0-255 reicht) oder `short`/`int`.
*   `Groesse`: `int` (in cm) oder `float`/`double` (in m).
*   `Augenfarbe`: `string` oder `enum`.
*   `Gewicht`: `float` oder `double`.
*   `Geschlecht`: `bool` (Männlich/Weiblich - vereinfacht) oder `enum` (besser).

**2. Konstante PI (4 Stellen):**
`const double PI = 3.1415;`

**3. Enum Tageszeiten:**
```csharp
enum Tageszeit { Morgen, Mittag, Abend, Mitternacht }
```

**4. Decimal mit 7,3:**
`decimal dWert = 7.3m;` (Wichtig: Das 'm' Suffix!)
