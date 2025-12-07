using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class AssigningApprenticeToAGroupTBL:BaseEntity
    {
        private ApprenticeTBL idOfApprentice;
        private GroupsTBL idOfTheGroup;

        public ApprenticeTBL IdOfApprentice { get => idOfApprentice; set => idOfApprentice = value; }
        public GroupsTBL IdOfTheGroup { get => idOfTheGroup; set => idOfTheGroup = value; }
    }
}
