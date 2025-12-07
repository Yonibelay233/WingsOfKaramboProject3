using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class AssigningGroupToActionDB : BaseDB
    {
        public AssigningGroupToActionTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM AssigningGroupToActionTBL";
            AssigningGroupToActionTBList groupList = new AssigningGroupToActionTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AssigningGroupToActionTBL ca = entity as AssigningGroupToActionTBL;
            ca.IdOfAction = ActionDB.SelectById((int)reader["IdOfAction"]);
            ca.Idofgroup = GroupsDB.SelectById((int)reader["idofgroup"]);
            base.CreateModel(entity);
            return ca;
        }
        public override BaseEntity NewEntity()
        {
            return new AssigningGroupToActionTBL();
        }
        static private AssigningGroupToActionTBList list = new AssigningGroupToActionTBList();

        public static AssigningGroupToActionTBL SelectById(int id)
        {
            AssigningGroupToActionDB db = new AssigningGroupToActionDB();
            list = db.SelectAll();

            AssigningGroupToActionTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningGroupToActionTBL aga = entity as AssigningGroupToActionTBL;
            if (aga != null)
            {
                string sqlStr = $"DELETE FROM AssigningGroupToActionTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", aga.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningGroupToActionTBL aga = entity as AssigningGroupToActionTBL;
            if (aga != null)
            {
                string sqlStr = $"Insert INTO  AssigningGroupToActionTBL (Idofgroup,IdOfAction) VALUES (@Idofgroup,@IdOfAction)";
                    

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@Idofgroup", aga.Idofgroup.Id));
                command.Parameters.Add(new OleDbParameter("@IdOfAction", aga.IdOfAction.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningGroupToActionTBL aga = entity as AssigningGroupToActionTBL;
            if (aga != null)
            {
                string sqlStr = $"UPDATE AssigningGroupToActionTBL  SET Idofgroup=@Idofgroup,IdOfAction=@IdOfAction WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@Idofgroup", aga.Idofgroup.Id));
                command.Parameters.Add(new OleDbParameter("@IdOfAction", aga.IdOfAction.Id));
                command.Parameters.Add(new OleDbParameter("@id", aga.Id));
            }
        }






    }
}

