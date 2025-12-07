using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class AssigningChildrenToAGroupTBL:BaseEntity
    {
        private ChildWithSpecialNeedTBL iDOfTheChildren;
        private GroupsTBL iDOfTheGroup;

        public ChildWithSpecialNeedTBL IDOfTheChildren { get => iDOfTheChildren; set => iDOfTheChildren = value; }
        public GroupsTBL IDOfTheGroup { get => iDOfTheGroup; set => iDOfTheGroup = value; }
    }
}
