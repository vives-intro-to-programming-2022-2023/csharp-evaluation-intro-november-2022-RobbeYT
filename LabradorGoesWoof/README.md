# Labrador Goes Woof

Deze applicatie is een onderdeel van een blaf-detector voor honden. Een apparaatje maakt geluidsopnames en geeft elk uur een resultaat terug in de vorm van een string volgens een bepaald formaat.

Voorbeeld van output:

```text
xxBxxBxxxxBxxxxxxBBBxxxxxBxxBxxxxBBxxxxxBxxxxxxBxxxxxxBxxxxB
```

De strings stelt een geluidsmeting voor over een tijdspanne van 60 minuten. Elke minuut wordt voorgesteld door een karakter `x` of een karakter `B`. Een `x` betekend dat de hond niet heeft geblaft binnen die minuut en het karakter `B` geeft aan dat de hond wel heeft geblaft.

Deze C# applicatie dient de string te parsen en terug te geven hoe dikwijls de hond in dat uur heeft geblaft.

De methode die je dient te implementeren is de `CountBarks` methode in `BarkCounter.cs`.

Jouw opdracht bestaat uit volgende taken (`View => TaskList`):

1. Overloop de `input` string en tel hoe dikwijls je een `B` karakter tegen komt
2. Laat de methode het resultaat returnen (aantal keer dat er `B` in `input` voorkomt)
3. Uitzondering - Indien de string niet bestaat uit `60` karakters dien je `-1` terug te geven om aan te geven dat het fout liep.

## Verwachte Werking

De `Main()` methode voorziet reeds een kleine demo applicatie die je kan uitvoeren. Indien je alles implementeert zoals verwacht, zou je volgende output moeten krijgen van de applicatie:

```text
Welcome to Labrador Goes Woof

Let's see how many times your dog barked today:

8h-9h: 10 time(s)
10h-11h: 27 time(s)
11h-12h: 0 time(s)
12h-13h: 0 time(s)
14h-15h: 33 time(s)
16h-17h: 1 time(s)

Thank you for using Labrador Goes Woof
```

## Unit Tests

Dit project bevat ook unit tests. Je kan deze uitvoeren via `Test => Run All Tests`.
