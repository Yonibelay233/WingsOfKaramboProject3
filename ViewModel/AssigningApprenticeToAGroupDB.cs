using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class AssigningApprenticeToAGroupDB : BaseDB
    {
        public AssigningApprenticeToAGroupTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM AssigningApprenticeToAGroupTBL";
            AssigningApprenticeToAGroupTBList groupList = new AssigningApprenticeToAGroupTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AssigningApprenticeToAGroupTBL ag = entity as AssigningApprenticeToAGroupTBL;
            ag.IdOfApprentice = ApprenticeDB.SelectById((int)reader["IdOfApprentice"]);
            ag.IdOfTheGroup= GroupsDB.SelectById((int)reader["IdOfTheGroup"]);
            base.CreateModel(entity);
            return ag;
        }
        public override BaseEntity NewEntity()
        {
            return new AssigningApprenticeToAGroupTBL();
        }
        static private AssigningApprenticeToAGroupTBList list = new AssigningApprenticeToAGroupTBList();

        public static AssigningApprenticeToAGroupTBL SelectById(int id)
        {
            AssigningApprenticeToAGroupDB db = new AssigningApprenticeToAGroupDB();
            list = db.SelectAll();

            AssigningApprenticeToAGroupTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningApprenticeToAGroupTBL aag = entity as AssigningApprenticeToAGroupTBL;
            if (aag != null)
            {
                string sqlStr = $"DELETE FROM AssigningApprenticeToAGroupTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", aag.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningApprenticeToAGroupTBL aag = entity as AssigningApprenticeToAGroupTBL;
            if (aag != null)
            {
                string sqlStr = $"Insert INTO  AssigningApprenticeToAGroupTBL (IdOfApprentice,IdOfTheGroup) VALUES " +
                    $"(@IdOfApprentice,@IdOfTheGroup)";
                    

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IdOfApprentice", aag.IdOfApprentice.Id));
                command.Parameters.Add(new OleDbParameter("@IdOfTheGroup", aag.IdOfTheGroup.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningApprenticeToAGroupTBL aag = entity as AssigningApprenticeToAGroupTBL;
            if (aag != null)
            {
                string sqlStr = $"UPDATE AssigningApprenticeToAGroupTBL  SET IdOfApprentice=@IdOfApprentice,IdOfTheGroup=@IdOfTheGroup" +
                    $" WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IdOfApprentice", aag.IdOfApprentice.Id));
                command.Parameters.Add(new OleDbParameter("@IdOfTheGroup", aag.IdOfTheGroup.Id));
                command.Parameters.Add(new OleDbParameter("@id", aag.Id));
            }
        }






    }
}
