using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class ActionTBL:BaseEntity
    {
        private string theSubjectOfTheAction;
        private DateTime dateOfTheAction;

        public string TheSubjectOfTheAction { get => theSubjectOfTheAction; set => theSubjectOfTheAction = value; }
        public DateTime DateOfTheAction { get => dateOfTheAction; set => dateOfTheAction = value; }
    }
}
