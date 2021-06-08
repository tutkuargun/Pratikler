using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaslangicEkranı();
        }

        static void BaslangicEkranı()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    BoardListele();
                    break;
                case 2:
                    BoardaKartEkle();
                    break;
                case 3:
                    BoardtanKartSil();
                    break;
                case 4:
                    KartTasi();
                    break;
                default:
                    Console.WriteLine("HATALI SEÇİM!");
                    BaslangicEkranı();
                    break;
            }

        }
        static void BoardListele()
        {
            BoardYonetimi boardIslemleri = new BoardYonetimi();
            var boardElements = boardIslemleri.BoardListele();

            ListBoardTodoElements(boardElements.Where(x => x.Kolon == BoardKolon.TODO).Select(x => new Kart()
            {
                Baslik = x.Kart.Baslik,
                Icerik = x.Kart.Icerik,
                AtananId = x.Kart.AtananId,
                Boyut = x.Kart.Boyut

            }).ToList());
            ListBoardInProgressElements(boardElements.Where(x => x.Kolon == BoardKolon.INPROGRESS).Select(x => new Kart()
            {
                Baslik = x.Kart.Baslik,
                Icerik = x.Kart.Icerik,
                AtananId = x.Kart.AtananId,
                Boyut = x.Kart.Boyut

            }).ToList());
            ListBoardDoneElements(boardElements.Where(x => x.Kolon == BoardKolon.DONE).Select(x => new Kart()
            {
                Baslik = x.Kart.Baslik,
                Icerik = x.Kart.Icerik,
                AtananId = x.Kart.AtananId,
                Boyut = x.Kart.Boyut

            }).ToList());

            BaslangicEkranı();


        }
        private static void ListBoardTodoElements(List<Kart> kartlar)
        {
            UyeYonetimi uyeIslemleri = new UyeYonetimi();

            Console.WriteLine("TODO Line");
            Console.WriteLine("*****************");


            foreach (var kart in kartlar)
            {
                Console.WriteLine("Başlık : " + kart.Baslik);
                Console.WriteLine("İçerik : " + kart.Icerik);
                Console.WriteLine("Atanan Kişi : " + uyeIslemleri.UyeBul(kart.AtananId).Name);
                Console.WriteLine("Büyüklük : " + kart.Boyut.ToString());
                Console.WriteLine("--------------------------------------------");
            }
        }

        private static void ListBoardInProgressElements(List<Kart> kartlar)
        {
            UyeYonetimi uyeIslemleri = new UyeYonetimi();

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*****************");


            foreach (var kart in kartlar)
            {
                Console.WriteLine("Başlık : " + kart.Baslik);
                Console.WriteLine("İçerik : " + kart.Icerik);
                Console.WriteLine("Atanan Kişi : " + uyeIslemleri.UyeBul(kart.AtananId).Name);
                Console.WriteLine("Büyüklük : " + kart.Boyut.ToString());
                Console.WriteLine("--------------------------------------------");
            }
        }

        private static void ListBoardDoneElements(List<Kart> kartlar)
        {
            UyeYonetimi uyeIslemleri = new UyeYonetimi();

            Console.WriteLine("DONE Line");
            Console.WriteLine("*****************");


            foreach (var kart in kartlar)
            {
                Console.WriteLine("Başlık : " + kart.Baslik);
                Console.WriteLine("İçerik : " + kart.Icerik);
                Console.WriteLine("Atanan Kişi : " + uyeIslemleri.UyeBul(kart.AtananId).Name);
                Console.WriteLine("Büyüklük : " + kart.Boyut.ToString());
                Console.WriteLine("--------------------------------------------");
            }
        }

        static void BoardaKartEkle()
        {
            Kart kart = new Kart();
            UyeYonetimi uyeYonetimi = new UyeYonetimi();
            BoardYonetimi boardYonetimi = new BoardYonetimi();

            Console.WriteLine("Başlık Giriniz");
            kart.Baslik = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz");
            kart.Icerik = Console.ReadLine();

            Console.WriteLine("Büyüklük Giriniz => XS(1), S(2), M(3), L(4), XL(5)");
            kart.Boyut = (KartBoyutu)int.Parse(Console.ReadLine());

            Console.WriteLine("Kişi Numarası Giriniz");
            int uyeId = int.Parse(Console.ReadLine());

            if (uyeYonetimi.UyeBul(uyeId) == null)
            {
                Console.WriteLine("Girilen Numarada Kullanıcı Bulunamadı.");
                BaslangicEkranı();
            }

            kart.AtananId = uyeId;
            var result = boardYonetimi.KartEkle(kart);

            if (result)
                Console.WriteLine("Kart Başarıyla Board'a Eklendi.");
            else
                Console.WriteLine("Kart Board'a Eklenemedi.");

            BaslangicEkranı();

        }
        static void BoardtanKartSil()
        {
            Console.WriteLine("Öncelikle Silmek İstediğiniz Kartı Seçmeniz Gerekiyor.");
            Console.WriteLine("Lütfen Kart Başlığını Yazınız.");

            BoardYonetimi boardYonetimi = new BoardYonetimi();
            var BoardElementBul = boardYonetimi.KartlaBoardElemanıBul(Console.ReadLine());

            if (BoardElementBul == null)
            {
                Console.WriteLine("Aradığınız Kart Bulunamadı.");
                Console.WriteLine("Ana Menüye Dön (1)");
                Console.WriteLine("Tekrar Dene (2)");

                int processType = int.Parse(Console.ReadLine());

                if (processType == 1)
                    BaslangicEkranı();
                else if (processType == 2)
                    BoardtanKartSil();
            }

            var result = boardYonetimi.KartSil(BoardElementBul);

            if (result)
                Console.WriteLine("Kart Başarıyla Board'dan Silindi.");
            else
                Console.WriteLine("Kart Board'dan Silinemedi.");

            BaslangicEkranı();
        }
        static void KartTasi()
        {
            Console.WriteLine("Öncelikle Taşımak İstediğiniz Kartı Seçmeniz Gerekiyor.");
            Console.WriteLine("Lütfen Kart Başlığını Yazınız.");

            BoardYonetimi boardYonetimi = new BoardYonetimi();
            var BoardElementBul = boardYonetimi.KartlaBoardElemanıBul(Console.ReadLine());

            if (BoardElementBul == null)
            {
                Console.WriteLine("Aradığınız Kart Bulunamadı.");
                Console.WriteLine("Ana Menüye Dön (1)");
                Console.WriteLine("Tekrar Dene (2)");

                int processType = int.Parse(Console.ReadLine());

                if (processType == 1)
                    BaslangicEkranı();
                else if (processType == 2)
                    KartTasi();
            }

            PrintBoardElementDetails(BoardElementBul);
            PrintChangeLineText();
            int lineValue = int.Parse(Console.ReadLine());

            if (lineValue < 1 || lineValue > 3)
            {
                Console.WriteLine("Hatalı Seçim Yaptınız.");
                BaslangicEkranı();
            }

            BoardElementBul.Kolon = (BoardKolon)lineValue;
            var result = boardYonetimi.KartTasi(BoardElementBul);

            if (result)
                Console.WriteLine("Kart Başarıyla Taşındı.");
            else
                Console.WriteLine("Kart Taşınamadı.");

            BaslangicEkranı();
        }

        static void PrintBoardElementDetails(BoardElement boardElement)
        {
            UyeYonetimi uyeYonetimi = new UyeYonetimi();

            Console.WriteLine("Bulunan Kart Bilgileri");
            Console.WriteLine("************************************");
            Console.WriteLine("Başlık : " + boardElement.Kart.Baslik);
            Console.WriteLine("İçerik : " + boardElement.Kart.Icerik);
            Console.WriteLine("Atanan Kişi : " + uyeYonetimi.UyeBul(boardElement.Kart.AtananId).Name);
            Console.WriteLine("Büyüklük : " + boardElement.Kart.Boyut.ToString());
            Console.WriteLine("Line : " + (boardElement.Kolon.ToString()));
        }

        private static void PrintChangeLineText()
        {
            Console.WriteLine("Lütfen Taşımak İstediğiniz Line'ı Seçiniz.");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");

        }
    }
}
