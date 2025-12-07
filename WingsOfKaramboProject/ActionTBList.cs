using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class ActionTBList:List<ActionTBL>
    {
        public ActionTBList() { }
        public ActionTBList(IEnumerable<ActionTBL> list) : base(list) { }
        public ActionTBList(IEnumerable<BaseEntity> list) : base(list.Cast<ActionTBL>().ToList()) { }
    }
}
