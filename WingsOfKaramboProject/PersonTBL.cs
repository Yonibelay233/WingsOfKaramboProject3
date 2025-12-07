using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class PersonTBL:BaseEntity
    {
        private string idPerson;
        private string firstName;
        private string lastName;
        private string street;
        private int buildingNumber;
        private BranchTBL branchCode;
        private DateTime dateOfBirth;
        private CityTBL city;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Street { get => street; set => street = value; }
        public int BuildingNumber { get => buildingNumber; set => buildingNumber = value; }
        public BranchTBL BranchCode { get => branchCode; set => branchCode = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public CityTBL City { get => city; set => city = value; }
        public string IdPerson { get => idPerson; set => idPerson = value; }
    }
}
