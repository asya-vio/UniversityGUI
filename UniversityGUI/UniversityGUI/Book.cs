using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    class Book
    {
        public string Name;
        public List <string> Author = new List<string>();
        public string ExpertiseArea;
        public List<BookExemplar> ListOfExemplar = new List<BookExemplar>();

        public Book(string name, string[] author, string expertiseArea)
        {
            Name = name;

            foreach (string a in author)
                Author.Add(a);

            ExpertiseArea = expertiseArea;
        }

        public void AddExemplar()
        {
            Console.WriteLine("Введите год издания экземпляра");

            int date = int.Parse(Console.ReadLine());

            ListOfExemplar.Add(new BookExemplar(date));
        }

        public void DeleteExemplar()
        {
            Console.WriteLine("Введите инвентарный номер экземпляра");

            int inventoryNumb = int.Parse(Console.ReadLine());

            for (int i = 0; i < ListOfExemplar.Count; i++)
            {
                if (ListOfExemplar[i].InventoryNumber == inventoryNumb)
                {
                    ListOfExemplar.RemoveAt(i);
                    break;
                }
            }
        }

        public void ShowExemplars()
        {
            Console.WriteLine("Всего {0} экземпляров", ListOfExemplar.Count - 1);
            for (int i = 0; i < ListOfExemplar.Count; i++)
            {
                Console.WriteLine("Инвентарный номер = {0}, год издания {1}", 
                    ListOfExemplar[i].InventoryNumber, ListOfExemplar[i].PublicationDate);
            }
        }

        public void ShowFreeExemplars()
        {
            foreach (BookExemplar bookEx in ListOfExemplar)
            {
                if (bookEx.Presence == Item.presence.yes)
                    Console.WriteLine("Инвентарный номер = {0}, год издания {1}",
                    bookEx.InventoryNumber, bookEx.PublicationDate);
            }
        }
    }
}
