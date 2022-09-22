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