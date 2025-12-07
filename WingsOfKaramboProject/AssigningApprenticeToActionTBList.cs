using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class AssigningApprenticeToActionTBList:List<AssigningApprenticeToActionTBL>
    {
        public AssigningApprenticeToActionTBList() { }
        public AssigningApprenticeToActionTBList(IEnumerable<AssigningApprenticeToActionTBL> list) : base(list) { }
        public AssigningApprenticeToActionTBList(IEnumerable<BaseEntity> list) : base(list.Cast<AssigningApprenticeToActionTBL>().ToList()) { }
    }
}
