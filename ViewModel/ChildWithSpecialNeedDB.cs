using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class ChildWithSpecialNeedDB : PersonDB
    {
        public ChildWithSpecialNeedList SelectAll()
        {
            command.CommandText = $"SELECT PersonTBL.*, ChildWithSpecialNeedsTBL.Transportation, ChildWithSpecialNeedsTBL." +
                $"[Parent'sPhoneNumber], ChildWithSpecialNeedsTBL.RestrictionCode, ChildWithSpecialNeedsTBL.Comments,\r\n" +
                $"ChildWithSpecialNeedsTBL.School\r\nFROM (ChildWithSpecialNeedsTBL INNER JOIN\r\n PersonTBL ON " +
                $"ChildWithSpecialNeedsTBL.ID = PersonTBL.ID)";
            ChildWithSpecialNeedList groupList = new ChildWithSpecialNeedList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ChildWithSpecialNeedTBL csn = entity as ChildWithSpecialNeedTBL;
            csn.Transportation = Convert.ToBoolean(reader["Transportation"]);
            csn.ParentsPhoneNumber = reader["Parent'sPhoneNumber"].ToString();
            csn.RestrictionCode = SpecialNeedsDB.SelectById((int)reader["RestrictionCode"]);
            csn.Comments = reader["Comments"].ToString();
            csn.School = SchoolDB.SelectById((int)reader["School"]);
            base.CreateModel(entity);
            return csn;
        }
        public override BaseEntity NewEntity()
        {
            return new ChildWithSpecialNeedTBL();
        }
        static private ChildWithSpecialNeedList list = new ChildWithSpecialNeedList();

        public static ChildWithSpecialNeedTBL SelectById(int id)
        {
            ChildWithSpecialNeedDB db = new ChildWithSpecialNeedDB();
            list = db.SelectAll();

            ChildWithSpecialNeedTBL g = list.Find(item => item.Id == id);
            return g;
        }


        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ChildWithSpecialNeedTBL csn = entity as ChildWithSpecialNeedTBL;
            if (csn != null)
            {
                string sqlStr = $"DELETE FROM ChildWithSpecialNeedTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", csn.Id));
            }
        }

        public override void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                inserted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
            }
        }


        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ChildWithSpecialNeedTBL csn = entity as ChildWithSpecialNeedTBL;
            if (csn != null)
            {
                string sqlStr = $"Insert INTO  ChildWithSpecialNeedTBL (Transportation,ParentsPhoneNumber,RestrictionCode,Comments,School)" +
                    $" VALUES " + $"(@Transportation,@ParentsPhoneNumber,@RestrictionCode,@Comments,@School)";
                    

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@Transportation", csn.Transportation));
                command.Parameters.Add(new OleDbParameter("@ParentsPhoneNumber", csn.ParentsPhoneNumber));
                command.Parameters.Add(new OleDbParameter("@RestrictionCode", csn.RestrictionCode.Id));
                command.Parameters.Add(new OleDbParameter("@Comments", csn.Comments));
                command.Parameters.Add(new OleDbParameter("@School", csn.School.Id));
            }
        }

        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ChildWithSpecialNeedTBL csn = entity as ChildWithSpecialNeedTBL;
            if (csn != null)
            {
                string sqlStr = $"UPDATE ChildWithSpecialNeedTBL  SET School=@School,Comments=@Comments,Transportation=@Transportation," +
                    $"ParentsPhoneNumber=@ParentsPhoneNumber," + "RestrictionCode=@RestrictionCode WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@School", csn.School.Id));
                command.Parameters.Add(new OleDbParameter("@Comments", csn.Comments));
                command.Parameters.Add(new OleDbParameter("@Transportation", csn.Transportation));
                command.Parameters.Add(new OleDbParameter("@ParentsPhoneNumber", csn.ParentsPhoneNumber));
                command.Parameters.Add(new OleDbParameter("@RestrictionCode", csn.RestrictionCode.Id));
                command.Parameters.Add(new OleDbParameter("@id", csn.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            ChildWithSpecialNeedTBL ChildWithSpecialNeed = entity as ChildWithSpecialNeedTBL;
            if (ChildWithSpecialNeed != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
    }
}
