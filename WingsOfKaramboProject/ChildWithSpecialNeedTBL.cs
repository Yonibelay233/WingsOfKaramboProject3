using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class ChildWithSpecialNeedTBL : PersonTBL 
    {
            private bool transportation;
        private string parentsPhoneNumber;
        private SpecialNeedsTBL restrictionCode;
        private string comments;
        private SchoolTBL school;

        public bool Transportation { get => transportation; set => transportation = value; }
        public string ParentsPhoneNumber { get => parentsPhoneNumber; set => parentsPhoneNumber = value; }
        public SpecialNeedsTBL RestrictionCode { get => restrictionCode; set => restrictionCode = value; }
        public string Comments { get => Comments; set => Comments = value; }
        public SchoolTBL School { get => school; set => school = value; }
    }
}
