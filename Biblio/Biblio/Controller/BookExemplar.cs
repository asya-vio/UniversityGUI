using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{    
    class BookExemplar : Item
        {
            public int PublicationDate { get; set; }

            public BookExemplar(int date, string number)
            {              
                PublicationDate = date;
                Presence = presence.yes;
                InventoryNumber = number;
            }
        }
    }

