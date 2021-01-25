# L0002B-introduction
## Inlämningsuppgift 2 

- Lösningsförslaget skall visas i ett flödesschema, pseudokod eller annan metod för algoritmbeskrivning 
- Skriv ett program som läser in uppgifter för ett antal säljare i en säljkår. Om en konsolapplikation, låt användaren mata in hur många säljare hen vill registrera. Det kan exempelvis se ut enligt följande: 
    - Namn: g
    - Personnummer: 
    - Distrikt: 
    - Antal sålda artiklar: 

Man har ett bonussystem där viss del av lönen är fast och en viss del är rörlig. Den rörliga delen baseras på antal sålda artiklar. Man vill kunna se statistik över försäljningen.

Det finns fyra nivåer: < 50 artiklar; 50-99 artiklar; 100-199 artiklar; > 199 artiklar. 

Resultatet skall sorteras innan det skrivs ut. Sorteringen sker på antal sålda artiklar. I utskriften skall alla resultat i sorterad ordning finnas med samt hur många säljare som ligger inom varje nivå samt hur många artiklar var och en har sålt.

Ex.
Namn        Persnr      Distrikt        Antal
Kalle Anka  4503038990  Piteå           173 
1 säljare har nått nivå 3: 100-199 artiklar

Musse Pigg  3502038964  Boden           202 
Snobben     7805055673  Luleå           203 
2 säljare har nått nivå 4: över 199 artiklar

Resultatet skall visas på skärmen och skrivas till en fil. 
