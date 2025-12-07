using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class StaffMemberTBList:List<StaffMemberTBL>
    {
        public StaffMemberTBList() { }
        public StaffMemberTBList(IEnumerable<StaffMemberTBL> list) : base(list) { }
        public StaffMemberTBList(IEnumerable<BaseEntity> list) : base(list.Cast<StaffMemberTBL>().ToList()) { }
    }
}
