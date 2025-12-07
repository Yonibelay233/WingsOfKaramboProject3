using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class AssigningChildrenToAGroupTBList:List<AssigningChildrenToAGroupTBL>
    {
        public AssigningChildrenToAGroupTBList() { }
        public AssigningChildrenToAGroupTBList(IEnumerable<AssigningChildrenToAGroupTBL> list) : base(list) { }
        public AssigningChildrenToAGroupTBList(IEnumerable<BaseEntity> list) : base(list.Cast<AssigningChildrenToAGroupTBL>().ToList()) { }
    }
}
