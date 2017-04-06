using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Pass
    {
        public int IDPass { get; set; }
        public int IDLibrary { get; set; }

        public Pass (int IDPass, int IDLibrary)
        {
            if (IDPass <= 0) throw new Exception("Неверный ID абонемента");
            if (IDLibrary <= 0) throw new Exception("Неверный ID библиотеки");

            this.IDPass = IDPass;
            this.IDLibrary = IDLibrary;
        }

        //public List<BookExemplar> ShowBooks(List<ItemLending>)
        //{
       
        //}

    }
}
