using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    class BookExpertiseArea
    {
        public string Name;
        public List<Book> ListOfBook;

        public BookExpertiseArea(string Name)
        {
            this.Name = Name;
            List<Book> ListOfBook = new List<Book>();

        }

        public void AddBook()
        {
            List<string> authors = new List<string>(); 

            Console.WriteLine("Введите введите название книги");
            string name = Console.ReadLine();

            Console.WriteLine("Введите введите количество авторов книги");
            int numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < numb; i++)
            {
                Console.WriteLine("Введите фамилию {1} автора книги", i);
                string author = Console.ReadLine();
                authors.Add(author);
            }

            ListOfBook.Add(new Book(name, authors.ToArray(), Name));
        }

        public void DeleteBook()
        {
            List<string> authors = new List<string>();

            Console.WriteLine("Введите введите название книги");
            string name = Console.ReadLine();

            Console.WriteLine("Введите введите количество авторов книги");
            int numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < numb; i++)
            {
                Console.WriteLine("Введите фамилию {1} автора книги", i+1);
                string author = Console.ReadLine();
                authors.Add(author);
            }

            for (int i = 0; i < ListOfBook.Count; i++)
            {
                if (ListOfBook[i].Name == name)
                {
                    if (ListOfBook[i].Author.SequenceEqual(authors))
                    {
                        ListOfBook.RemoveAt(i);
                        Console.WriteLine("Книга успешно удалена");
                        return;
                    }

                }
            }
            Console.WriteLine("Нет такой кники!");
            Console.ReadLine();
            return;
        }
    }
}
