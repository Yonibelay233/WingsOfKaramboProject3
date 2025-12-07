using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class SchoolTBList:List<SchoolTBL>
    {
        public SchoolTBList() { }
        public SchoolTBList(IEnumerable<SchoolTBL> list) : base(list) { }
        public SchoolTBList(IEnumerable<BaseEntity> list) : base(list.Cast<SchoolTBL>().ToList()) { }
    }
}
