﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Student : Man
    {
        public int IDStudentCard { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }

        public StudentPass Pass { get; set; }

        public Student (string lastname, string name, string secondname, string adress, string phonenumber,
            int IDStudentCard, string Faculty, int Course)
            : base(lastname, name, secondname, adress, phonenumber)
        {
            if (IDStudentCard <= 0) throw new Exception("Неверный ID карты студента");

            if (string.IsNullOrEmpty(Faculty)) throw new Exception("Не задан факультет студент!");
            if (Course <= 0) throw new Exception("Не правильно задан курс для студента!");

            this.IDStudentCard = IDStudentCard;
            this.Faculty = Faculty;
            this.Course = Course;
        }
        
    }
}