using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Book
    {
        public string Name;
        public List<string> Author = new List<string>();
        //public string ExpertiseArea;
        public List<BookExemplar> ListOfExemplar = new List<BookExemplar>();

        public Book(string name, string[] author)
        {
            Name = name;

            foreach (string a in author)
                Author.Add(a);

            ///ExpertiseArea = expertiseArea;
        }

        public void AddExemplar(int PublicationDate, int InventoryNumber)
        {
            ListOfExemplar.Add(new BookExemplar(PublicationDate, InventoryNumber));
        }

        public void DeleteExemplar(int InventoryNumber)
        {
            for (int i = 0; i < ListOfExemplar.Count; i++)
            {
                if (ListOfExemplar[i].InventoryNumber == InventoryNumber)
                {
                    ListOfExemplar.RemoveAt(i);
                    break;
                }
            }
        }

        public List<BookExemplar> ShowExemplars()
        {
            return ListOfExemplar; 
        }

        public List<BookExemplar> ShowFreeExemplars()
        {
            List<BookExemplar> resultList = new List<BookExemplar>();
            foreach (BookExemplar bookEx in ListOfExemplar)
            {
                if (bookEx.Presence == Item.presence.yes) resultList.Add(bookEx);
            }
            return resultList;          
        }
        
    }
}
