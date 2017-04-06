using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Biblio
{
    public class Man
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Man (string lastName, string name, string secondName, string address,
            string phonenumber)
        {
            //if (string.IsNullOrEmpty(name)) throw new Exception("Неверное имя человека!");

            //Regex reg = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");

            //if (!reg.IsMatch(PhoneNumber)) throw new Exception("Неверный номер телефона!");

            this.LastName = lastName;
            this.Name = name;
            this.SecondName = secondName;
            this.Address = address;
            this.PhoneNumber = phonenumber;
        }

    }
}
