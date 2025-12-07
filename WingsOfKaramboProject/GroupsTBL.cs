using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class GroupsTBL:BaseEntity
    {
        private string nameOfGroups;
        private GuideTBL idOfGuide;

        public string NameOfGroups { get => nameOfGroups; set => nameOfGroups = value; }
        public GuideTBL IdOfGuide { get => idOfGuide; set => idOfGuide = value; }
    }
}
