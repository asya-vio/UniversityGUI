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
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

        public Man (string lastname, string name, string secondname, string adress,
            string phonenumber)
        {
            //if (string.IsNullOrEmpty(name)) throw new Exception("Неверное имя человека!");

            //Regex reg = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");

            //if (!reg.IsMatch(PhoneNumber)) throw new Exception("Неверный номер телефона!");

            this.LastName = lastname;
            this.Name = name;
            this.SecondName = secondname;
            this.Adress = adress;
            this.PhoneNumber = phonenumber;
        }

    }
}
