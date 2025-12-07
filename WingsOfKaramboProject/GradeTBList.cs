using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class GradeTBList:List<GradeTBL>
    {
        public GradeTBList() { }
        public GradeTBList(IEnumerable<GradeTBL> list) : base(list) { }
        public GradeTBList(IEnumerable<BaseEntity> list) : base(list.Cast<GradeTBL>().ToList()) { }
    }
}
