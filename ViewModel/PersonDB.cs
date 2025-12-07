
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class PersonDB : BaseDB
    {
        public PersonTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM PersonTBL";
            PersonTBList pList = new PersonTBList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            PersonTBL p = entity as PersonTBL;
            p.IdPerson = reader["IdPerson"].ToString();
            p.FirstName = reader["firstName"].ToString();
            p.LastName = reader["lastName"].ToString();
            p.City = CityDB.SelectById((int)reader["city"]);
            p.Street = reader["Street"].ToString();
            p.BuildingNumber =int.Parse(reader["BuildingNumber"].ToString());
            p.BranchCode = BranchDB.SelectById((int)reader["BranchCode"]);
            p.DateOfBirth =(DateTime)reader["DateOfBirth"];
            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new PersonTBL();
        }
        static private PersonTBList list = new PersonTBList();
        public static PersonTBL SelectById(int id)
        {
            PersonDB db = new PersonDB();
            list = db.SelectAll();

            PersonTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PersonTBL p = entity as PersonTBL;
            if (p != null)
            {
                string sqlStr = $"DELETE FROM PersonTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", p.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PersonTBL p = entity as PersonTBL;
            if (p != null)
            {
                string sqlStr = $"Insert INTO  PersonTBL (FirstName,IdPerson,Street,LastName,BuildingNumber,City,BranchCode,DateOfBirth) " +
                    $"VALUES (@FirstName,@IdPerson,@Street,@LastName,@BuildingNumber,@City,@BranchCode,@DateOfBirth)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@FirstName", p.FirstName));
                command.Parameters.Add(new OleDbParameter("@IdPerson", p.IdPerson));
                command.Parameters.Add(new OleDbParameter("@Street", p.Street));
                command.Parameters.Add(new OleDbParameter("@LastName", p.LastName));
                command.Parameters.Add(new OleDbParameter("@BuildingNumber", p.BuildingNumber));
                command.Parameters.Add(new OleDbParameter("@City", p.City.Id));
                command.Parameters.Add(new OleDbParameter("@BranchCode", p.BranchCode.Id));
                command.Parameters.Add(new OleDbParameter("@DateOfBirth", p.DateOfBirth));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PersonTBL p = entity as PersonTBL;
            if (p != null)
            {
                string sqlStr = $"UPDATE PersonTBL  SET FirstName=@FirstName,IdPerson=@IdPerson,Street=@Street," +
                    $"LastName=@LastName,BuildingNumber=@BuildingNumber,City=@City,BranchCode=@BranchCode,DateOfBirth=@DateOfBirth WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@FirstName", p.FirstName));
                command.Parameters.Add(new OleDbParameter("@IdPerson", p.IdPerson));
                command.Parameters.Add(new OleDbParameter("@Street", p.Street));
                command.Parameters.Add(new OleDbParameter("@LastName", p.LastName));
                command.Parameters.Add(new OleDbParameter("@BuildingNumber", p.BuildingNumber));
                command.Parameters.Add(new OleDbParameter("@City", p.City.Id));
                command.Parameters.Add(new OleDbParameter("@BranchCode", p.BranchCode.Id));
                command.Parameters.Add(new OleDbParameter("@DateOfBirth", p.DateOfBirth));
                command.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }




    }
}
