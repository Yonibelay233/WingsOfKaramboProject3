using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class AssigningGroupToActionTBList:List<AssigningGroupToActionTBL>
    {
        public AssigningGroupToActionTBList() { }
        public AssigningGroupToActionTBList(IEnumerable<AssigningGroupToActionTBL> list) : base(list) { }
        public AssigningGroupToActionTBList(IEnumerable<BaseEntity> list) : base(list.Cast<AssigningGroupToActionTBL>().ToList()) { }
    }
}
