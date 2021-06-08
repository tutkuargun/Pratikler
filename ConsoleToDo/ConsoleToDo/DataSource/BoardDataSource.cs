using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleToDo.DataSource
{
    class BoardDataSource
    {
        public static Board Board;

        static BoardDataSource()
        {
            Board = BoardYaz();
        }

        static Board BoardYaz()
        {
            return new Board
            {
                boardElements = new List<BoardElement>()
                {
                    new BoardElement()
                    {
                        Kart = new Kart("Kart Başlığı 1 ", "Burada kart içeriği var",2,KartBoyutu.S),
                        Kolon = (BoardKolon.TODO)

                    },
                    new BoardElement()
                    {
                        Kart = new Kart("Kart Başlığı 2 ", "Burada kart içeriği var",1,KartBoyutu.M),
                        Kolon =  (BoardKolon.INPROGRESS)

                    },
                    new BoardElement()
                    {
                        Kart = new Kart("Kart Başlığı 3 ", "Burada kart içeriği var",2,KartBoyutu.L),
                        Kolon =  (BoardKolon.TODO)

                    },

                }
            };
        }
    }
}
