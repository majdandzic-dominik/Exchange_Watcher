# Exchange_Watcher

Za pokretanje pomoću Visual Studio potrebno je skinuti i instalirati Visual Studio Community Edition.

Za otvaranje projekta pokrenite "ExchangeWatcher.sln" koji se nalazi unutar glavnog foldera "ExchangeWatcher". (može se otvoriti preko Visual Studia File->Open->Project/Solution
nakon čega se odabere "ExchangeWatcher.sln", ili desnim klikom na "ExchangeWatcher.sln" i open with Visual Studio)

Unutar solution-a se nalaze 3 projekta: ExchangeWatcher (glavna aplikacija, grafički prikazi vrijednosti valuta, registracija i spremanje postavki o obaviještavanju korisnika), 
ExchangeWatcherUpdater (aplikacija koja se svaki dan pokreće samo na jednom računalu, tj. severu, i ona sprema nove vrijednosti valuta na bazu podataka) 
i ExchangeWatcherEmailSender (također se pokreće samo na jednom računalu svaki dan nakon ExchangeWatcherUpdatera, on šalje obavijesti preko emaila korisnicima o promjeni vrijednosti praćene valute).
Također se još nalaze i ExchangeWatcherClassLibrary s potrebnim klasama za rad programa, 
ExchangeWatcher.UnitTests u kojem se nalaze unit testovi za registracijsku formu,  
te ExchangeWatcherSetup unutar kojeg se nalazi instalacija za glavni program.

Ako imate instaliran Visual Studio možete preko njega pokretati projekte tako što u solution exploreru desnim klikom stisnete na "Solution 'ExchangeWatcher'" zatim na properties.
Unutar properties-a otiđite u CommonProperties->StartupProject zatim označite "Single startup project" i odaberite iz liste projekt koji želite da se pokreće, stisnite apply, zatim 
možete zatvoriti properties prozor. Za pokretanje odabranog projekta u toolbaru kliknite na Debug->Start Without Debugging ili pritisnite Ctrl+F5.

Ako nemate instaliran visual studio aplikacije možete pokrenuti pomoću njihovih .exe fileova.
Putanje do .exe fileova:
ExchangeWatcherEmailSender: "ExchangeWatcher\ExchangeWatcherEmailSender\bin\Debug\netcoreapp3.1\ExchangeWatcherEmailSender.exe"
ExchangeWatcherUpdater: "ExchangeWatcher\ExchangeWatcherUpdater\bin\Debug\netcoreapp3.1\ExchangeWatcherUpdater.exe"

Za pokretanje glavnog programa bez Visual Studia potrebno je instalirati program.
Lokacija instalacije:"ExchangeWatcher\ExchangeWatcherSetup\Release\ExchangeWatcherSetup.msi"
Nakon instalacije stvoriti će se shortcut na desktop.


Napomena za ExchangeWatcherEmailSender. Ponekad se emailovi neće poslati zato što se nekoliko dana za redom vrijednosti valuta ne mijenjaju.
