//Creare una classe Prodotto che gestisce i prodotti dello shop.
//Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private):
//i costruttori,
//i metodi getter e setter
//eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nel vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

// ---------------------------------

//A partire da quanto già fatto con csharp-oop-shop dove vi era stato chiesto di creare una classe Prodotto generica per gestire un generico prodotto dello Shop, vi chiedo di essere più specifici e di creare le sottoclassi opportune di alcuni prodotti che potremmo identificare nel nostro shop.
//In particolare immaginiamo che nel nostro shop possiamo commerciare le seguenti tipologie di prodotto:
//Acqua(massimo 1.5L)
//Sacchetto di Frutta a pezzi (al massimo puo contenere 5 pezzi di frutta)
//Elettrodomestico
//Cibo in Scatola (al massimo può contenere 300g di peso su una scatola)
//Per ognuno dei seguenti prodotti più specifici vi si chiede di identificare quali potrebbero essere i loro attributi e metodi che eventualmente gli riguardano, ereditando i metodi e gli attributi generici dalla classe Prodotto creata nell’esercizio precedente.
//Un esempio per la classe Acqua che eredità Prodotto è aggiungere i seguenti attributi e metodi:
//attributo litri: per indicare quanti litri di acqua ci sono nella bottiglia di acqua
//attributo ph: che indica il livello di acidità dell’acqua (sola lettura)
//attributo sorgente: che indica la sorgente di provenienza dell’acqua (sola lettura)
//... ecc ecc
//metodo bevi (double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti.
//metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a non riempirla troppo.
//metodo svuota() che rimuove tutta l’acqua dalla bottiglia.
//metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse Prodotto (se non lo avete già fatto dichiaratelo anche nella classe prodotto è si occupa di stampare il “codice - nome”, l lo abbiamo chiamato NomeEsteso), per stampare oltre al codice e al nome dell’acqua, anche la sua sorgente, il ph e i litri contenuti.
//un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei litri in galloni, sapendo che 1 litro è equivalente a 3,785 galloni (ricordatevi di codificare le costanti come 3.785 nel modo corretto come visto in classe).
//Ricordatevi di creare questi metodi in maniera responsabile, in modo che non rendono “incoerente” lo stato dei vostri oggetti (ad esempio non posso bere più dei litri contenuti nella bottiglia, o non posso riempire più di tot una bottiglia!).

Prodotto prodotto = new Prodotto();

prodotto.SetNome("Asus ROG");
prodotto.SetDescrizione("Monitor da gaming full HD blabla");
prodotto.SetPrezzo(299);
prodotto.SetIva(20);

Console.WriteLine("Il tuo Prodotto - Specifiche");
Console.WriteLine($"Codice: {prodotto.GetCodice()}");
Console.WriteLine($"Nome: {prodotto.GetNome()}");
Console.WriteLine($"Descrizione: {prodotto.GetDescrizione()}");
Console.WriteLine($"Prezzo: {prodotto.GetPrezzo()}");
Console.WriteLine($"Prezzo + IVA: {prodotto.GetPrezzoIva()}");
Console.WriteLine($"Nome Prodotto Esteso: {prodotto.GetNomeEsteso()}");
