using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class StudentPass : Pass
    {
        public Student StudentInfo { get; set; }

        public const int TimeQuota = 400;
        public const int AmountQuota = 5;

        public StudentPass(Student StudentInfo, int IDPass, int IDLibrary)
            : base(IDPass, IDLibrary)
        {
            if (StudentInfo == null) throw new Exception("Не указан студент для абонемента");

            this.StudentInfo = StudentInfo;
            StudentInfo.Pass = this;
        }
    }
}
