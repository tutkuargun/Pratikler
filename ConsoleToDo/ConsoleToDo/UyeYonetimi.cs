using ConsoleToDo.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleToDo
{
    class UyeYonetimi
    {
        public Uye UyeBul(int uyeId)
        {
            return UyeDataSource.Uyeler.FirstOrDefault(x => x.Id == uyeId);
        }
    }
}
