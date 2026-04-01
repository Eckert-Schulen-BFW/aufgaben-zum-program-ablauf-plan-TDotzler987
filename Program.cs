// ============================================================
//  Aufgabe: Programmablaufplan – BMI-Rechner
//  Fach:    C# Grundlagen
//  Name:    [DEIN NAME HIER]
//  Datum:   [DATUM HIER]
// ============================================================
//
// AUFGABE 1 – Beantworte folgende Fragen hier als Kommentar:
//
// Frage 1: Wie viele Entscheidungsknoten (Rauten) hat der PAP?
// Antwort: 6
//
// Frage 2: Unter welchen Bedingungen endet das Programm frühzeitig?
// Antwort: fehlerhafter Eingabe
//
// Frage 3: Warum wird TryParse statt Convert.ToDouble() verwendet?
// Antwort: um bei fehlerhafter Eingabe keinen Fehler ausgeworfen zu bekommen
//
// Frage 4: Welchen Datentyp sollen gewicht und groesse haben, und warum?
// Antwort: wird in double formatiert und danach mit Diesem weitergerechnet
//
// ============================================================

// TODO: Schreibe dein Programm unterhalb dieser Zeile.
//       Orientiere dich dabei am PAP in der README.md.
//       Jeder Schritt im PAP sollte einer Zeile / einem Block in deinem Code entsprechen.

// ── Schritt 1: Programmtitel ausgeben ───────────────────────
// Tipp: Nutze Console.WriteLine() für die Titelbox.
// TODO: Ausgabe der Titelzeile (wie im Beispiel in der README)
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("╔══════════════════════════════════╗");
Console.WriteLine("║        BMI - Rechner v1.0        ║");
Console.WriteLine("╚══════════════════════════════════╝");
Console.WriteLine();
Console.WriteLine("Bitte gib deinen Namen ein: ");
string name = Console.ReadLine();
Console.WriteLine("Bitte gib dein Gewicht in kg ein: ");
string weight = Console.ReadLine(); 
double weightnum;
bool eingabeweight = double.TryParse(weight, out weightnum);
//   true/false     = Datentyp.TryParse(string welchen, out wohin wir das konvertiere schreiben);
//   true   => wenn konvertierung erfolgreich!
//   false  => wenn konvertierung nicht erfolgreich!
if (eingabeweight)
{
    Console.WriteLine("Bitte geben Sie Ihre Größe in m ein: ");
    string size = Console.ReadLine();
    double sizenum;
    bool eingabesize = double.TryParse(size, out sizenum);
    if (eingabesize)
    {
        if (sizenum > 0)
        {
            double BMI = (weightnum / sizenum * sizenum);
            string kategorie = "";
            if (BMI < 18.5)
                kategorie = "Untergewicht";
            else if (BMI < 25)
                kategorie = "Normalgewicht";
            else if (BMI < 30)
                kategorie = "Übergewicht";
            else
                kategorie = "starkes Übergewicht";

        
        Console.WriteLine("Name: " + name);
        Console.WriteLine("BMI: " + BMI);
        Console.WriteLine("Kategorie: " + kategorie);
        }

    }

} 
else
{
    Console.WriteLine("Fehler");
    
}return;




// ── Schritt 2: Eingabe – Name ────────────────────────────────
// TODO: Benutzernamen einlesen (string, kein TryParse nötig)


// ── Schritt 3: Eingabe – Gewicht mit Validierung ─────────────
// TODO: Gewicht als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)


// ── Schritt 4: Eingabe – Größe mit Validierung ───────────────
// TODO: Körpergröße als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)
// TODO: Zusätzlich prüfen: Ist die Größe größer als 0?
//       Falls nicht → eigene Fehlermeldung und Programm beenden (return)


// ── Schritt 5: BMI berechnen ─────────────────────────────────
// Formel: BMI = Gewicht / (Größe * Größe)
// TODO: BMI berechnen und in einer Variablen speichern


// ── Schritt 6: Kategorie bestimmen ───────────────────────────
// TODO: Erstelle eine string-Variable "kategorie"
// TODO: Bestimme die Kategorie über eine if-else-if-Kette:
//       BMI < 18.5        → "Untergewicht"
//       BMI < 25.0        → "Normalgewicht"
//       BMI < 30.0        → "Übergewicht"
//       sonst (else)      → "Starkes Übergewicht"
//
// 💭 Denkfrage: Warum reicht bei "Normalgewicht" die Bedingung BMI < 25.0 aus,
//               obwohl laut WHO-Tabelle auch BMI >= 18.5 gelten muss?


// ── Schritt 7: Ergebnis ausgeben ─────────────────────────────
// TODO: Gib Name, BMI (auf 2 Dezimalstellen) und Kategorie formatiert aus
// Tipp: Nutze z.B. $"{bmi:F2}" für 2 Nachkommastellen
