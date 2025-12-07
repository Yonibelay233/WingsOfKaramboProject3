
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class GroupsDB : BaseDB
    {
        public GroupsTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM GroupsTBL";
            GroupsTBList groupList = new GroupsTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            GroupsTBL gu = entity as GroupsTBL;
            gu.NameOfGroups = reader["NameOfGroups"].ToString();
            gu.IdOfGuide = GuideDB.SelectById((int)reader["IdOfGuide"]);
            base.CreateModel(entity);
            return gu;
        }
        public override BaseEntity NewEntity()
        {
            return new GroupsTBL();
        }
        static private GroupsTBList list = new GroupsTBList();

        public static GroupsTBL SelectById(int id)
        {
            GroupsDB db = new GroupsDB();
            list = db.SelectAll();

            GroupsTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GroupsTBL gr = entity as GroupsTBL;
            if (gr != null)
            {
                string sqlStr = $"DELETE FROM GroupsTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", gr.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GroupsTBL gr = entity as GroupsTBL;
            if (gr != null)
            {
                string sqlStr = $"Insert INTO  GroupsTBL (NameOfGroups,IdOfGuide) VALUES (@NameOfGroups,@IdOfGuide)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@NameOfGroups", gr.NameOfGroups));
                command.Parameters.Add(new OleDbParameter("@IdOfGuide", gr.IdOfGuide.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GroupsTBL gr = entity as GroupsTBL;
            if (gr != null)
            {
                string sqlStr = $"UPDATE GroupsTBL  SET NameOfGroups=@NameOfGroups,IdOfGuide=@IdOfGuide WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@NameOfGroups", gr.NameOfGroups));
                command.Parameters.Add(new OleDbParameter("@IdOfGuide", gr.IdOfGuide));
                command.Parameters.Add(new OleDbParameter("@id", gr.Id));
            }
        }





    }
}
