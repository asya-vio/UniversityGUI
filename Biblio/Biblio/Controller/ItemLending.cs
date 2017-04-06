using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    class ItemLanding
    {
        public int IDLanding { get; set; }

        public DateTime LandingDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public int IDLibrary { get; set; }

        public int EmployeeNumber { get; set; }

        public int IDPass { get; set; }

        public bool IsStud { get; set; }

        public string InventoryNumber { get; set; }

        public ItemLanding
            (int ID, DateTime LandDate, DateTime RetDate, int IDLib, int EmpNum, 
            int IDPass, bool IsStud, string InvNum)
        {
            IDLanding = ID;

            LandingDate = LandDate;

            ReturnDate = LandDate;

            IDLibrary = IDLib;

            EmployeeNumber = EmpNum;

            this.IDPass = IDPass;

            this.IsStud = IsStud;

            InventoryNumber = InvNum;
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
