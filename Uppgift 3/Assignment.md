# Uppgiftsbeskrivning (38p)

Uppgiften är att dela upp en monolit till en modern mikroservice-arkitektur.
Genom att tillämpa olika teorier om hur man delar upp en kodbas vill man att
eleven själv kan föra ett resonemang i arkitektur-bild och skrift.

Kom ihåg att det finns flera svar som kan vara rätt här. Det viktigaste är att
du i ditt resonemang visar att du haft en tanke med din uppdelning. Beskriv
också eventuella avvägningar du gjort rörande vilken data som sparas var och
vilken information olika tjänster känner till.


Den befintliga monolit-lösningen beskrivs dels i skissen *yournews.png* och i
texten nedan:

YourNews är en webbtidning som nås via en webbsajt. Webbsajten har 3 olika vyer.
För att läsa nyheterna på sajten måste användaren vara registrerad och betala
för en prenumeration.

* Startsidan
  * På startsidan kan prenumeranter registrera sig. Vi behöver inte tänka på hur
    prenumeranten loggar in. Vi kan anta att hen är inloggad efter
    registreringen.
  * Listar nyheter för betalande prenumeranter
    * För varje nyhet skriv nyhetens rubrik ut. Vid klick på rubriken skickar
      prenumeranten till nyhetssidan.
* Nyhetssidan
  * På nyhetssidan visas information om 1 nyhet
  * Nyheten har en rubrik, en text och en bild som alla visas på sidan
  * Författaren av nyheten visas också med namn och bild
  * På sidan visas också kommentarer som prenumeranter skrivit om nyheten
    * Varje kommentar har information om vem som skrivit den (namn och bild)
      samt dess text
* Adminsida
  * Här kan prenumeranten ändra sitt namn och bild
  * Prenumeranten kan också lista sina tidigare betalningar


För full poäng:
* Dela upp i tjänster med valfritt tänk i bildform
* Resonera i text kring varför du valde en viss uppdelning av tjänsterna
* Nämn 2 fördelar med att dela upp i tjänster
* Nämn 2 nackdelar med att dela upp i tjänster

Inlämningen ska vara en arkitekturskissen (format: PNG) och ett textdokument
(format: Word, PDF, text). Spara båda dokumenten i samma mapp som denna
beskrivning.
* Arkitekturskissen kan tas fram i valfritt program men måste skickas in i
  PNG-format. Förslagsvis använder ni något av de program vi använt tidigare i
  kursen: Draw.io eller Mural
* Textdokumentet ska innehålla följande:
  - Ett resonemang om din mikroservice-uppdelning. Här är det viktigt att knyta
    an till de tekniker och resonemang som finns kring att dela upp monoliter
  - 2 fördelar med att dela upp i tjänster
  - 2 nackdelar med att dela upp i tjänster

Det är viktigt att du skriver så att det går att förstå vad du menar. Om vi inte
förstår vad du menar i ditt svar kan vi dra av poäng. Det spelar ingen roll att
du efteråt kan förklara vad du menar. Texten och skissen måste stå för sig
själva.
