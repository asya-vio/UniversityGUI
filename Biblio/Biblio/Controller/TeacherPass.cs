using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Controller
{
    class TeacherPass : Pass
    {
        public Teacher TeacherInfo { get; set; }

        public const int TimeQuota = 600;
        public const int AmountQuota = 20;

        public TeacherPass (Teacher TeacherInfo, int IDPass, int IDLibrary)
            : base (IDPass, IDLibrary)
        {
            if (TeacherInfo == null) throw new Exception("Не указан преподаватель для абонемента");

            this.TeacherInfo = TeacherInfo;
            TeacherInfo.Pass = this;
        }
    }
}
