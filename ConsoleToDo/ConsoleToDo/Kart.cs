using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleToDo
{
    class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int AtananId { get; set; }
        public KartBoyutu Boyut { get; set; }

        public Kart(string baslik, string icerik, int atananId, KartBoyutu boyut)
        {
            this.Baslik = baslik;
            this.Icerik = icerik;
            this.AtananId = atananId;
            this.Boyut = boyut;
        }
        public Kart()
        {

        }
    }
}
