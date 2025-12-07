
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class BranchDB : BaseDB
    {
        public BranchTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM BranchTBL";
            BranchTBList groupList = new BranchTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            BranchTBL br = entity as BranchTBL;
            br.NameOfBranch = reader["NameOfBranch"].ToString();
            br.City = CityDB.SelectById((int)reader["city"]);
            base.CreateModel(entity);
            return br;
        }
        public override BaseEntity NewEntity()
        {
            return new BranchTBL();
        }
        static private BranchTBList list = new BranchTBList();

        public static BranchTBL SelectById(int id)
        {
            BranchDB db = new BranchDB();
            list = db.SelectAll();

            BranchTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            BranchTBL b = entity as BranchTBL;
            if (b != null)
            {
                string sqlStr = $"DELETE FROM BranchTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", b.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            BranchTBL b = entity as BranchTBL;
            if (b != null)
            {
                string sqlStr = $"Insert INTO  BranchTBL (NameOfBranch,City) VALUES (@NameOfBranch,@City)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@NameOfBranch", b.NameOfBranch));
                command.Parameters.Add(new OleDbParameter("@City", b.City.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            BranchTBL b = entity as BranchTBL;
            if (b != null)
            {
                string sqlStr = $"UPDATE BranchTBL  SET City=@cName,NameOfBranch=@NameOfBranch WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", b.City));
                command.Parameters.Add(new OleDbParameter("@NameOfBranch", b.NameOfBranch));
                command.Parameters.Add(new OleDbParameter("@id", b.Id));
            }
        }





    }
}
