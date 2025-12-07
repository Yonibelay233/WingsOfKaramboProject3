using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class AssigningChildrenToAGroupDB : BaseDB
    {
        public AssigningChildrenToAGroupTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM AssigningChildrenToAGroupTBL";
            AssigningChildrenToAGroupTBList groupList = new AssigningChildrenToAGroupTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AssigningChildrenToAGroupTBL cg = entity as AssigningChildrenToAGroupTBL;
            cg.IDOfTheGroup = GroupsDB.SelectById((int)reader["IdOfTheGroup"]);
            cg.IDOfTheChildren = ChildWithSpecialNeedDB.SelectById((int)reader["IDOfTheChildren"]);
            base.CreateModel(entity);
            return cg;
        }
        public override BaseEntity NewEntity()
        {
            return new AssigningChildrenToAGroupTBL();
        }
        static private AssigningChildrenToAGroupTBList list = new AssigningChildrenToAGroupTBList();

        public static AssigningChildrenToAGroupTBL SelectById(int id)
        {
            AssigningChildrenToAGroupDB db = new AssigningChildrenToAGroupDB();
            list = db.SelectAll();

            AssigningChildrenToAGroupTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningChildrenToAGroupTBL acg = entity as AssigningChildrenToAGroupTBL;
            if (acg != null)
            {
                string sqlStr = $"DELETE FROM AssigningChildrenToAGroupTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", acg.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningChildrenToAGroupTBL acg = entity as AssigningChildrenToAGroupTBL;
            if (acg != null)
            {
                string sqlStr = $"Insert INTO  AssigningChildrenToAGroupTBL (IDOfTheChildren,IDOfTheGroup) VALUES " +
                    $"(@IDOfTheChildren,@IDOfTheGroup)";
                    

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IDOfTheChildren", acg.IDOfTheChildren.Id));
                command.Parameters.Add(new OleDbParameter("@IDOfTheGroup", acg.IDOfTheGroup.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AssigningChildrenToAGroupTBL acg = entity as AssigningChildrenToAGroupTBL;
            if (acg != null)
            {
                string sqlStr = $"UPDATE AssigningChildrenToAGroupTBL  SET IDOfTheChildren=@IDOfTheChildren,IDOfTheGroup=@IDOfTheGroup" +
                    $" WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IDOfTheChildren", acg.IDOfTheChildren.Id));
                command.Parameters.Add(new OleDbParameter("@IDOfTheGroup", acg.IDOfTheGroup.Id));
                command.Parameters.Add(new OleDbParameter("@id", acg.Id));
            }
        }






    }
}

