
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class SpecialNeedsDB : BaseDB
    {
        public SpecialNeedsTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM SpecialNeedsTBL";
            SpecialNeedsTBList groupList = new SpecialNeedsTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            SpecialNeedsTBL sn = entity as SpecialNeedsTBL;
            sn.DescriptionOfOSpecialNeeds = reader["DescriptionOfOSpecialNeeds"].ToString();
            base.CreateModel(entity);
            return sn;
        }
        public override BaseEntity NewEntity()
        {
            return new SpecialNeedsTBL();
        }
        static private SpecialNeedsTBList list = new SpecialNeedsTBList();

        public static SpecialNeedsTBL SelectById(int id)
        {
            SpecialNeedsDB db = new SpecialNeedsDB();
            list = db.SelectAll();

            SpecialNeedsTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SpecialNeedsTBL sn = entity as SpecialNeedsTBL;
            if (sn != null)
            {
                string sqlStr = $"DELETE FROM SpecialNeedsTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", sn.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SpecialNeedsTBL sn = entity as SpecialNeedsTBL;
            if (sn != null)
            {
                string sqlStr = $"Insert INTO  SpecialNeedsTBL (DescriptionOfOSpecialNeeds) VALUES (@DescriptionOfOSpecialNeeds)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@DescriptionOfOSpecialNeeds", sn.DescriptionOfOSpecialNeeds));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SpecialNeedsTBL sn = entity as SpecialNeedsTBL;
            if (sn != null)
            {
                string sqlStr = $"UPDATE SpecialNeedsTBL  SET DescriptionOfOSpecialNeeds=@DescriptionOfOSpecialNeeds WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@DescriptionOfOSpecialNeeds", sn.DescriptionOfOSpecialNeeds));
                command.Parameters.Add(new OleDbParameter("@id", sn.Id));
            }
        }




    }
}
