using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class GuideTBL:PersonTBL
    {
        private bool whoWasInTrainingCourse;

        public bool WhoWasInTrainingCourse { get => whoWasInTrainingCourse; set => whoWasInTrainingCourse = value; }
    }
}
