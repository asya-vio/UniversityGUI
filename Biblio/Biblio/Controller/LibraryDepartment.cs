using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class LibraryDepartment : ItemLender
    {

        public LibraryDepartment(ItemLenderBase dataBase) : base (dataBase)
        {
            this.DataBase = dataBase;

            LendedItem = new List<ItemLending>();

        }

    }
}
