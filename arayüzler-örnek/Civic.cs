namespace arayüzler_örnek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renkler StandartRengiNe()
        {
           return Renkler.Gri;
        }
    }
}