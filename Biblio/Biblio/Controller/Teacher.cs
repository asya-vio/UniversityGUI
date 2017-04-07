﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Teacher : Man
    {
        public int TeacherNumber { get; set; }
        public string Faculty { get; set; }
        public string Job { get; set; }

        public TeacherPass Pass { get; set; }

        public Teacher(string lastName, string name, string secondName, string address, string phoneNumber,
            int TeacherNumber, string Faculty, string Job)
            : base(lastName, name, secondName, address, phoneNumber)
        {
            if (TeacherNumber <= 0) throw new Exception("Неверный ID карты преподавателя");

            if (string.IsNullOrEmpty(Faculty)) throw new Exception("Не задан факультет преподавателя!");
            if (string.IsNullOrEmpty(Job)) throw new Exception("Не задана должность преподавателя!");

            this.TeacherNumber = TeacherNumber;
            this.Faculty = Faculty;
            this.Job = Job;
        }
    }
}
