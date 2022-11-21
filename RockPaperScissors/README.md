# Rock - Paper - Scissors

Blad, steen, schaar is een wijdverbreid spel dat met de hand gespeeld wordt.

Het spel wordt gebruikt om te loten, bijvoorbeeld om te bepalen wie aan de beurt is bij een spel zoals tikkertje, verstoppertje of varianten daarvan. Het voordeel hierbij is dat er geen derde element nodig is (zoals bij het raden van een getal), en geen materiaal zoals bij kop of munt en een dobbelsteen rollen. De uitkomst is onvoorspelbaar, in tegenstelling tot het gebruik van een aftelrijmpje.

![Rock, Paper, Scissors](./img/rock_paper_scissors.png)

In deze C# applicatie kan de gebruiker tegen de computer spelen. Er wordt hiervoor een random hand gegenereerd voor de computer waartegen de gebruiker speelt.

Je dient hiervoor volgende methodes te implementeren in `Game.cs`:

* `GenerateComputerHand()`: genereer een random hand voor de computer (getal tussen 0 en 2) en geef afhankelijk van de waarde de strings `rock`, `paper` of `scissors` terug.
* `IsValidHand(string playerHand)`: return `true` als de opgegeven `playerHand` een geldige optie is voor een hand (`rock`, `paper` of `scissors`) of `false` indien de string geen heldige hand bevat.
* `DidPlayerWin(string playerHand, string computerHand)`: bepaal of de `playerHand` sterker is dan de `computerHand` door `true` te returnen in dat geval. Je mag er vanuit gaan dat beide argumenten een geldige waarde bevatten. Indien beide handen gelijk zijn, dien je `false` te returnen.

Je vindt de verschillende taken terug via `View => TaskList`.

## Verwachte Werking

De `Main()` methode voorziet reeds een kleine demo applicatie die je kan uitvoeren. Indien je alles implementeert zoals verwacht, zou je volgende output moeten krijgen van de applicatie:

```text
Welcome to Rock / Paper / Scissors

Please choose your weapon [rock,paper,scissors]: rack
Please choose your weapon [rock,paper,scissors]: rock

You chose rock while computer chose scissors
Congratz! You won !!!!!

Thanks for playing Rock / Paper / Scissors
```

## Unit Tests

Dit project bevat ook unit tests. Je kan deze uitvoeren via `Test => Run All Tests`.
