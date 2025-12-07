using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class SpecialNeedsTBL : BaseEntity
    {
        private string descriptionOfOSpecialNeeds;

        public string DescriptionOfOSpecialNeeds { get => descriptionOfOSpecialNeeds; set => descriptionOfOSpecialNeeds = value; }
    }
}
