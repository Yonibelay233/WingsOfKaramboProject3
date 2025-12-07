using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class StaffMemberTBL:PersonTBL
    {
        private RoleTBL roleCode;

        public RoleTBL RoleCode { get =>roleCode; set => roleCode = value; }
    }
}
