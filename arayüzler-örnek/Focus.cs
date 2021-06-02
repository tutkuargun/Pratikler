namespace arayüzler_örnek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Ford;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renkler StandartRengiNe()
        {
           return Renkler.Beyaz;
        }
    }
}