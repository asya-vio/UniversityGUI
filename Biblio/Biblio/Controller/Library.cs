using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    class Library
    {
        List<LibraryDepartment> ListLibraryDept;
        List<ReadingHall> ListReadingHall;

        public Library()
        {
            ListLibraryDept = new List<LibraryDepartment>();
            ListReadingHall = new List<ReadingHall>();
        }

        public void AddLibraryDept(BookCatalog bookCatalog, ItemLenderBase lenderBase, string ExpertiseArea)
        {
            ListLibraryDept.Add(new LibraryDepartment(lenderBase));
            //BookCatalog bookCatalog = new BookCatalog();
            //string ExpertiseArea = "Гуманитарная";

            //ItemLenderBase lenderBase = new ItemLenderBase(bookCatalog, ExpertiseArea);

            //LibraryDepartment libraryDept = new LibraryDepartment(lenderBase);

        }

        public void AddReadingHall(BookCatalog bookCatalog, ItemLenderBase lenderBase, string ExpertiseArea)
        {
            ListReadingHall.Add(new ReadingHall(lenderBase));
            //BookCatalog bookCatalog = new BookCatalog();
            //string ExpertiseArea = "Научный";

            //ItemLenderBase lenderBase = new ItemLenderBase(bookCatalog, ExpertiseArea);

            //ReadingHall libraryDept = new ReadingHall(lenderBase);
        }

        //по идеее, для внесения в базу новых библиотек и читальных залов, тоже нужна своя форма с запросом, но ее нет, потому что некогда
        //на название области знаний, это для тестового варианта
    }
}
