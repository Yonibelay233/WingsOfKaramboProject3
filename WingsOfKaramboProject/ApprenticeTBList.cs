using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class ApprenticeTBList:List<ApprenticeTBL>
    {
        public ApprenticeTBList() { }
        public ApprenticeTBList(IEnumerable<ApprenticeTBL> list) : base(list) { }
        public ApprenticeTBList(IEnumerable<BaseEntity> list) : base(list.Cast<ApprenticeTBL>().ToList()) { }
    }
}
