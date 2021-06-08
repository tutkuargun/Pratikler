using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleToDo
{
    class Uye
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Uye(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
