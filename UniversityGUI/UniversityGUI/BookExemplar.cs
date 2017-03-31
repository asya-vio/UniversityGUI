using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    class BookExemplar : Item
    {
        public int PublicationDate { get; set; }

        public BookExemplar(int date)
        {
            PublicationDate = date;
            Presence = presence.yes;
        }
    }
}
