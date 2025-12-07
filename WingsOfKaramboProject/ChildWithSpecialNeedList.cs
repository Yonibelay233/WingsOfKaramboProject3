using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class ChildWithSpecialNeedList:List<ChildWithSpecialNeedTBL>
    {
        public ChildWithSpecialNeedList() { }
        public ChildWithSpecialNeedList(IEnumerable<ChildWithSpecialNeedTBL> list) : base(list) { }
        public ChildWithSpecialNeedList(IEnumerable<BaseEntity> list) : base(list.Cast<ChildWithSpecialNeedTBL>().ToList()) { }
    }
}
