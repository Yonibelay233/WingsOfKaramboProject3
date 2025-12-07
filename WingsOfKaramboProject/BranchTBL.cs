using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class BranchTBL:BaseEntity
    {
        private string nameOfBranch;
        private CityTBL city;

        public string NameOfBranch { get => nameOfBranch; set => nameOfBranch = value; }
        public CityTBL City { get => city; set => city = value; }
    }
}
