using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleToDo
{
    class BoardElement
    {
        public Kart Kart { get; set; }
        public BoardKolon Kolon { get; set; }

        public BoardElement(Kart kart , BoardKolon kolon)
        {
            this.Kart = Kart;
            this.Kolon = kolon;

        }
        public BoardElement()
        {

        }

    }
}
