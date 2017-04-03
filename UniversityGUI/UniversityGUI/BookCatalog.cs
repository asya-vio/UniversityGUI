using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    class BookCatalog
    {
        public List<BookExpertiseArea> ListOfExpertiseArea;

        public BookCatalog()
        {
            ListOfExpertiseArea = new List<BookExpertiseArea>();
        }

        public void AddExpertiseArea()
        {
            Console.WriteLine("Введите название новой области");
            var name = Console.ReadLine();

            ListOfExpertiseArea.Add(new BookExpertiseArea(name));

        }

        public void DeleteExpertiseArea()
        {
            Console.WriteLine("Введите название области");
            var name = Console.ReadLine();

            int i;
            for (i = 0; i < ListOfExpertiseArea.Count; i++)
            {
                if (ListOfExpertiseArea[i].Name == name)
                {
                    ListOfExpertiseArea.RemoveAt(i);
                    break;
                }
            }
            if (i == ListOfExpertiseArea.Count - 1)
                Console.WriteLine("Нет такой области знаний!");
        }

        private Book FindByAuthor()
        {
            List<string> authors = new List<string>();
            Console.WriteLine("Введите введите количество авторов книги");
            int numb = int.Parse(Console.ReadLine());
            try
            {
                for (int i = 0; i < numb; i++)
                {
                    Console.WriteLine("Введите фамилию {1} автора книги", i);
                    string author = Console.ReadLine();
                    authors.Add(author);
                }

                for (int i = 0; i < ListOfExpertiseArea.Count; i++)
                {
                    for (int j = 0; j < ListOfExpertiseArea[i].ListOfBook.Count; j++)
                    {
                        if (ListOfExpertiseArea[i].ListOfBook[j].Author.SequenceEqual(authors))
                            return ListOfExpertiseArea[i].ListOfBook[j];
                    }
                }
                throw new ArgumentException("Такой книги нет в каталоге!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                string[] st = { "-1" };
                return new Book("-1", st, "-1");
            }
        }

        private Book FindByName()
        {
            Console.WriteLine("Введите навание книги");
            string name = Console.ReadLine();
            try
            {
                for (int i = 0; i < ListOfExpertiseArea.Count; i++)
                {
                    for (int j = 0; j < ListOfExpertiseArea[i].ListOfBook.Count; j++)
                    {
                        if (ListOfExpertiseArea[i].ListOfBook[j].Name == name)
                            return ListOfExpertiseArea[i].ListOfBook[j];                   
                    }
                }
                throw new ArgumentException("Такой книги нет в каталоге!");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                string[] st = { "-1" };
                return new Book("-1", st, "-1");
            }
        }

        public Book FindBook()
        {
            Console.WriteLine("Введите 1, если хотите искать по названию книги");
            Console.WriteLine("Введите 2, если хотите искать по авторам книги");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                var book = FindByName();
                    return book;
            }
            else
            {
                var book = FindByAuthor();
                return book;
            }      
        }

        public void Print()
        {
            for (int i = 0; i < ListOfExpertiseArea.Count; i++)
            {
                Console.WriteLine("Область знаний {0}", ListOfExpertiseArea[i]);
                for (int j = 0; j < ListOfExpertiseArea[i].ListOfBook.Count; j++)
                {
                    Console.WriteLine("Книга  {0}", ListOfExpertiseArea[i].ListOfBook[j]);                   
                }
                Console.WriteLine();
            }
        }
    }
}
