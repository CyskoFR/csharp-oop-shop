public class Acqua : Prodotto
{
    public float Litri { get; set; } = 1.5f;
    public float Ph { get; set; }
    public string Sorgente { get; }
    private const double gallone = 3.785;

    public Acqua(string sorgente)
    {
        Sorgente = sorgente;
    }
    public void Bevi(float litriDaBere)
    {
        Litri -= litriDaBere;
    }
    public void Riempi(float litriDaBere)
    {
        Litri += litriDaBere;
    }
    public void Svuota()
    {
        Litri = 0;
    }
    public static double convertiInGalloni(double litri)
    {
        return litri * gallone;
    }
}
