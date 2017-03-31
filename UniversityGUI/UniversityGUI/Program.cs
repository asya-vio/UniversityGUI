using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
     class Program
    {

        static void Main(string[] args)
        {


            //BookExemplar bookex = new BookExemplar(1992);
            //BookExemplar bookex2 = new BookExemplar(1993);

            //Console.WriteLine("{0}", bookex.InventoryNumber);
            //Console.WriteLine("{0}", bookex2.InventoryNumber);

            List<int> numb = new List<int>();
            for (int i = 0; i < 10; i++)
                numb.Add(i);

            numb.RemoveAt(5);

            for (int i = 0; i < numb.Count; i++)
                Console.WriteLine("{0}", numb[i]);
        }
    }
}
