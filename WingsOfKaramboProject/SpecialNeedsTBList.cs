using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class SpecialNeedsTBList:List<SpecialNeedsTBL>
    {
        public SpecialNeedsTBList() { }
        public SpecialNeedsTBList(IEnumerable<SpecialNeedsTBL> list) : base(list) { }
        public SpecialNeedsTBList(IEnumerable<BaseEntity> list) : base(list.Cast<SpecialNeedsTBL>().ToList()) { }
    }
}
