using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    abstract class Item
    {
        public enum presence { no, yes }
    
        public presence Presence { get; set; }

        public int InventoryNumber;

    }
}
