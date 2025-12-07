using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class ApprenticeTBL : PersonTBL
    {
        private SchoolTBL school;
        private GradeTBL grade;

        public SchoolTBL School { get => school; set => school = value; }
        public GradeTBL Grade { get => grade; set => grade = value; }
    }
}
