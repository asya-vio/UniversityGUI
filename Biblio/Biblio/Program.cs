using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
   public static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //BookCatalog catalog = new BookCatalog();
            //catalog.AddExpertiseArea("Наука");
            //catalog.AddExpertiseArea("Не наука");
            //string[] auth = { "Акапян", "Моисеенко" };

            //Book book1 = new Book("Книжечка", auth);
            //catalog.ListOfExpertiseArea[0].AddBook(book1);

            //Book book2 = new Book("Кнчка", auth);
            //catalog.ListOfExpertiseArea[1].AddBook(book2);

            //book1.AddExemplar(1987, 123);
            //book1.AddExemplar(1980, 124);

            //book2.AddExemplar(1890, 456);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());





        }
    }
}
