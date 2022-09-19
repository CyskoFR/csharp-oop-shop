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

public class Prodotto
{
    private int codice;
    private string nome;
    private string descrizione;
    private decimal prezzo;
    private int iva;

    public Prodotto()
    {
        Random r = new Random();
        this.codice = r.Next(1, 100000000);
    }

    public int GetCodice()
    {
        return this.codice;
    }

    public string GetNome()
    {
        return this.nome;
    }

    public string GetDescrizione()
    {
        return this.descrizione;
    }

    public decimal GetPrezzo()
    {
        return this.prezzo;
    }

    public int GetIva()
    {
        return this.iva;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public void SetDescrizione(string descrizione)
    {
        this.descrizione = descrizione;
    }

    public void SetPrezzo(decimal prezzo)
    {
        this.prezzo = prezzo;
    }

    public void SetIva(int iva)
    {
        this.iva = iva;
    }

    public decimal GetPrezzoIva()
    {
        decimal prezzoPiuIva = GetPrezzo() + (GetPrezzo() * GetIva() / 100);
        return prezzoPiuIva;
    }

    public string GetNomeEsteso()
    {
        return GetCodice() + GetNome().Replace(" ", String.Empty);
    }
}