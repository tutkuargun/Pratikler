using ConsoleToDo.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleToDo
{
    class BoardYonetimi
    {
        public List<BoardElement> BoardListele()
        {
            return BoardDataSource.Board.boardElements.ToList();

        }
        public bool KartEkle(Kart kart)
        {
            try
            {
                BoardDataSource.Board.boardElements.Add(new BoardElement(kart, BoardKolon.TODO));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public BoardElement KartlaBoardElemanıBul(string baslik)
        {
            return BoardDataSource.Board.boardElements.FirstOrDefault(x => x.Kart.Baslik.ToLower() == baslik.ToLower());
        }
        public bool KartSil(BoardElement boardElement)
        {
            try
            {
                BoardDataSource.Board.boardElements.Remove(boardElement);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool KartTasi(BoardElement boardElement)
        {
            try
            {
                foreach (var element in BoardDataSource.Board.boardElements)
                {
                    
                    if (element == boardElement)
                    {
                        element.Kolon = boardElement.Kolon;
                        break;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
