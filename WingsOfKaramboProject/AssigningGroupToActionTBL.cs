using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class AssigningGroupToActionTBL:BaseEntity
    {
        private ActionTBL idOfAction;
        private GroupsTBL idofgroup;

        public ActionTBL IdOfAction { get => idOfAction; set => idOfAction = value; }
        public GroupsTBL Idofgroup { get => idofgroup; set => idofgroup = value; }
    }
}
