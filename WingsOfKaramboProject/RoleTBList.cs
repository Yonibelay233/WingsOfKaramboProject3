using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class RoleTBList:List<RoleTBL>
    {
        public RoleTBList() { }
        public RoleTBList(IEnumerable<RoleTBL> list) : base(list) { }
        public RoleTBList(IEnumerable<BaseEntity> list) : base(list.Cast<RoleTBL>().ToList()) { }
    }
}
