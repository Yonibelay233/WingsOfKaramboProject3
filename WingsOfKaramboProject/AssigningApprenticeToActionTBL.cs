using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class AssigningApprenticeToActionTBL:BaseEntity
    {
        private ApprenticeTBL idOfApprentice;
        private ActionTBL idOfAction;

        public ApprenticeTBL IdOfApprentice { get => idOfApprentice; set => idOfApprentice = value; }
        public ActionTBL IdOfAction { get => idOfAction; set => idOfAction = value; }
    }
}
