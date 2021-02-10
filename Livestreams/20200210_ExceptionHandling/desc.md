# Live Coding: Passwortgenerator #

int.Parse(Console.ReadLine()) ist eine einfache Methode für das Einlesen einer Zahl.
Aber was geschieht, wenn der Benutzer keine Zahl eingibt, sondern sein Lieblingsessen? 
Das Programm stürzt ab. Gar nicht gut! :-(

Es gibt zumindest zwei Arten, wie man eine Zahl "sicher" einlesen kann.

## Ablauf ##
<ol>
<li>int.TryParse: C# überprüft selbst, ob Console.ReadLine() eine Zahl ist und gibt uns diese Information. Kein Absturz!</li>
<li>PAUSE (10 Min)</li>
<li>try-catch: Exception Handling</li>
</ol> 

## Stay tuned! ##