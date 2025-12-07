using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class GroupsTBList:List<GroupsTBL>
    {
        public GroupsTBList() { }
        public GroupsTBList(IEnumerable<GroupsTBL> list) : base(list) { }
        public GroupsTBList(IEnumerable<BaseEntity> list) : base(list.Cast<GroupsTBL>().ToList()) { }
    }
}
