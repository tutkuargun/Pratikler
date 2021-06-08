using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleToDo.DataSource
{
    class UyeDataSource
    {
        public static List<Uye> Uyeler;

        static UyeDataSource()
        {
            Uyeler=UyeleriYaz();
        }

        static List<Uye> UyeleriYaz()
        {
            return new List<Uye>()
            {
                new Uye (1,"Tutku Argun"),
                new Uye (2,"Sedef Sev"),
                new Uye (3,"Furkan Osman"),
                new Uye (4,"Ayşe Yılmaz"),
                new Uye (5, "Gökhan Işıl")

            };
        }

    }
}
