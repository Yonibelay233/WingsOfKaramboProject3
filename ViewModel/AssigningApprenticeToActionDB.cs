using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class AssigningApprenticeToActionDB : BaseDB
    {
        public AssigningApprenticeToActionTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM AssigningApprenticeToActionTBL";
            AssigningApprenticeToActionTBList groupList = new AssigningApprenticeToActionTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AssigningApprenticeToActionTBL aa = entity as AssigningApprenticeToActionTBL;
            aa.IdOfAction = ActionDB.SelectById((int)reader["IdOfAction"]);
            aa.IdOfApprentice = ApprenticeDB.SelectById((int)reader["IdOfApprentice"]);
            base.CreateModel(entity);
            return aa;
        }
        public override BaseEntity NewEntity()
        {
            return new AssigningApprenticeToActionTBL();
        }
        static private AssigningApprenticeToActionTBList list = new AssigningApprenticeToActionTBList();

        public static AssigningApprenticeToActionTBL SelectById(int id)
        {
            AssigningApprenticeToActionDB db = new AssigningApprenticeToActionDB();
            list = db.SelectAll();

            AssigningApprenticeToActionTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningApprenticeToActionTBL aaa = entity as AssigningApprenticeToActionTBL;
            if (aaa != null)
            {
                string sqlStr = $"DELETE FROM AssigningApprenticeToActionTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", aaa.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningApprenticeToActionTBL aaa = entity as AssigningApprenticeToActionTBL;
            if (aaa != null)
            {
                string sqlStr = $"Insert INTO  AssigningApprenticeToActionTBL (IdOfApprentice,IdOfAction) VALUES" +
                    $" (@IdOfApprentice,@IdOfAction)"; 
                    

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IdOfApprentice", aaa.IdOfApprentice.Id));
                command.Parameters.Add(new OleDbParameter("@IdOfAction", aaa.IdOfAction.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningApprenticeToActionTBL aaa = entity as AssigningApprenticeToActionTBL;
            if (aaa != null)
            {
                string sqlStr = $"UPDATE AssigningApprenticeToActionTBL  SET IdOfApprentice=@IdOfApprentice,IdOfAction=@IdOfAction WHERE" +
                    $" ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IdOfApprentice", aaa.IdOfApprentice.Id));
                command.Parameters.Add(new OleDbParameter("@IdOfAction", aaa.IdOfAction.Id));
                command.Parameters.Add(new OleDbParameter("@id", aaa.Id));
            }
        }




    }
}

