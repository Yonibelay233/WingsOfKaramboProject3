using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class PersonTBList:List<PersonTBL>
    {
        public PersonTBList() { }
        public PersonTBList(IEnumerable<PersonTBL> list) : base(list) { }
        public PersonTBList(IEnumerable<BaseEntity> list) : base(list.Cast<PersonTBL>().ToList()) { }
    }
}
