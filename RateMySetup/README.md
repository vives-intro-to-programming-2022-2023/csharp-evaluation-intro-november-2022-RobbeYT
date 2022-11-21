# Rate My Setup

Wanneer we een product of dienst beoordelen gaan we dit dikwijls grafisch voorstellen aan de hand van een "rating" - we geven een aantal "sterren" aan iets.

In deze CSharp applicatie dien je een beoordeling te genereren die we in de terminal kunnen tonen. Op die manier kan een "grafische" voorstelling worden getoond van een product of dienst.

Een voorbeeld van een rating wordt hieronder weergegeven (rating is 3/5):

```text
<###__>
```

Om dit systeem gebruiksvriendelijk te maken en om er voor te zorgen dat het ook voor andere applicaties toepasbaar is, voorzien we een aantal argumenten die kunnen worden gekozen:

* Het aantal `stars` kan je meegeven die het aantal "sterren" voorstelt die je geeft aan het product of de dienst
* Het totaal aantal sterren dat je kan geven onder de vorm van `maximum`
* Het symbool dat je wil gebruiken voor de "sterren"

Merk op dat de string telkens begint met `<` en eindigt met `>`. Daarnaast dien je voor lege "sterren" een underscore `_` te gebruiken

De methode die je dient te implementeren is de `Rate` methode in `RatingGenerator.cs`.

Jouw opdracht bestaat uit volgende taken (`View => TaskList`):

1. Maak een `string` variabel waarin je het resultaat gaat plaatsen
2. Bouw de string op volgens het opgegeven formaat (hint: maak gebruik van een loop-structuur)
3. Geef de resulterende string terug (geen `Console.WriteLine` hier!)
4. Uitzondering - Indien maximum `0` is of stars groter is dan maximum dien je als resultaat `"<>"` terug te geven.

## Verwachte Werking

De `Main()` methode voorziet reeds een kleine demo applicatie die je kan uitvoeren. Indien je alles implementeert zoals verwacht, zou je volgende output moeten krijgen van de applicatie:

```text
Welcome to Rate My Setup
Let's rate some things

Github Rating:   <*****>
TikTok Rating:   <_____>
LinkedIn Rating: <!!!!_>
C++ Rating:      <+++++++++_>
Python Rating:   <~~~~~~____>

Thank you for using Rate My Setup
```

## Unit Tests

Dit project bevat ook unit tests. Je kan deze uitvoeren via `Test => Run All Tests`.
