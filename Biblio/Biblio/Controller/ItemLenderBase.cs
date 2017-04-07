using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class ItemLenderBase
    {
        public string LenderExpertiseArea { get; set; }

        public BookCatalog Catalog { get; set; }

        public List<StudentPass> Students { get; set; }

        public List<TeacherPass> Teachers { get; set; }

        public List<Employee> Employees { get; set; }

        public ItemLenderBase(BookCatalog Catalog, string ExpArea)
        {
            LenderExpertiseArea = ExpArea;

            this.Catalog = Catalog;

            Students = new List<StudentPass>();

            Teachers = new List<TeacherPass>();

            Employees = new List<Employee>();
        }

        public void AddStudentPass (StudentPass pass)
        {
            Students.Add(pass);
        }

        public void DeleteStuddentPass (int IDPass)
        {
            foreach (StudentPass studentPass in Students)
            {
                if (studentPass.IDPass == IDPass)
                {
                    Students.Remove(studentPass);
                    return;
                }
            }
        }

        public void AddTeacherPass(TeacherPass pass)
        {
            Teachers.Add(pass);
        }

        public void DeleteTeacherPass(int IDPass)
        {
            foreach (TeacherPass teacherPass in Teachers)
            {
                if (teacherPass.IDPass == IDPass)
                {
                    Teachers.Remove(teacherPass);
                    return;
                }
            }
        }

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }

        public void DeleteEmployee(int EmployeeNumber)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.EmployeeNumber == EmployeeNumber)
                {
                    Employees.Remove(emp);
                    return;
                }
            }
        }

    }
}
