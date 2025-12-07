using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class ActionDB : BaseDB
    {
        public ActionTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ActionTBL";
            ActionTBList groupList = new ActionTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ActionTBL ac = entity as ActionTBL;
            ac.TheSubjectOfTheAction = reader["TheSubjectOfTheAction"].ToString();
            ac.DateOfTheAction= (DateTime)reader["DateOfTheAction"];
            base.CreateModel(entity);
            return ac;
        }
        public override BaseEntity NewEntity()
        {
            return new ActionTBL();
        }
        static private ActionTBList list = new ActionTBList();

        public static ActionTBL SelectById(int id)
        {
            ActionDB db = new ActionDB();
            list = db.SelectAll();

            ActionTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ActionTBL ac = entity as ActionTBL;
            if (ac != null)
            {
                string sqlStr = $"DELETE FROM ActionTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", ac.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ActionTBL ac = entity as ActionTBL;
            if (ac != null)
            {
                string sqlStr = $"Insert INTO  ActionTBL (TheSubjectOfTheAction,DateOfTheAction) VALUES " +
                    $"(@TheSubjectOfTheAction,@DateOfTheAction)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@TheSubjectOfTheAction", ac.TheSubjectOfTheAction));
                command.Parameters.Add(new OleDbParameter("@DateOfTheAction", ac.DateOfTheAction));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ActionTBL ac = entity as ActionTBL;
            if (ac != null)
            {
                string sqlStr = $"UPDATE ActionTBL  SET TheSubjectOfTheAction=@SubjectOfTheAction,DateOfTheAction=@DateOfTheAction WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@SubjectOfTheAction", ac.TheSubjectOfTheAction));
                command.Parameters.Add(new OleDbParameter("@DateOfTheAction", ac.DateOfTheAction));
                command.Parameters.Add(new OleDbParameter("@id", ac.Id));
            }
        }

        



    }
}
