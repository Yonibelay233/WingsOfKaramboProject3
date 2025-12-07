using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class CityTBList:List<CityTBL>
    {
        public CityTBList() { }
        public CityTBList(IEnumerable<CityTBL> list) : base(list) { }
        public CityTBList(IEnumerable<BaseEntity> list) : base(list.Cast<CityTBL>().ToList()) { }
        
    }
}
