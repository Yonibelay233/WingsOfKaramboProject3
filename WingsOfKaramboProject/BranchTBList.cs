using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class BranchTBList:List<BranchTBL>
    {
        public BranchTBList() { }
        public BranchTBList(IEnumerable<BranchTBL> list) : base(list) { }
        public BranchTBList(IEnumerable<BaseEntity> list) : base(list.Cast<BranchTBL>().ToList()) { }
    }
}
