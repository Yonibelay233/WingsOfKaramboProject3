using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class GuideTBList:List<GuideTBL>
    {
        public GuideTBList() { }
        public GuideTBList(IEnumerable<GuideTBL> list) : base(list) { }
        public GuideTBList(IEnumerable<BaseEntity> list) : base(list.Cast<GuideTBL>().ToList()) { }
    }
}
