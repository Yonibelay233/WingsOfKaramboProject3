using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class AssigningApprenticeToAGroupTBList:List<AssigningApprenticeToAGroupTBL>
    {
        public AssigningApprenticeToAGroupTBList() { }
        public AssigningApprenticeToAGroupTBList(IEnumerable<AssigningApprenticeToAGroupTBL> list) : base(list) { }
        public AssigningApprenticeToAGroupTBList(IEnumerable<BaseEntity> list) : base(list.Cast<AssigningApprenticeToAGroupTBL>().ToList()) { }
    }
}
