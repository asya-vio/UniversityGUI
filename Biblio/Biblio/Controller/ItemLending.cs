using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    class ItemLending
    {
        public int IDLending { get; set; }

        public DateTime LendingDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public int IDLibrary { get; set; }

        public int EmployeeNumber { get; set; }

        public int IDPass { get; set; }

        public bool IsStudent { get; set; }

        public int InventoryNumber { get; set; }

        public ItemLending
            (int ID, DateTime LendDate, DateTime RetDate, int IDLib, int EmpNum, 
            int IDPass, bool IsStud, int InventoryNumber)
        {
            IDLending = ID;

            LendingDate = LendDate;

            ReturnDate = LendDate;

            IDLibrary = IDLib;

            EmployeeNumber = EmpNum;

            this.IDPass = IDPass;

            this.IsStudent = IsStud;

            this.InventoryNumber = InventoryNumber;
        }

        public void ExtendDate (int days)
        {
            if (days > 0)
            {
                ReturnDate.AddDays(days);
            }
        }

    }
}
