using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class GuideDB : PersonDB
    {
        public GuideTBList SelectAll()
        {
            command.CommandText = $"SELECT PersonTBL.*,GuideTBL.WhoWasInTrainingCourse\r\nFROM (GuideTBL INNER JOIN\r\n " +
                $"PersonTBL " + $"ON GuideTBL.ID = PersonTBL.ID)";
            GuideTBList groupList = new GuideTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            GuideTBL g = entity as GuideTBL;
            g.WhoWasInTrainingCourse = Convert.ToBoolean(reader["WhoWasInTrainingCourse"]);
            base.CreateModel(entity);
            return g;
        }
        public override BaseEntity NewEntity()
        {
            return new GuideTBL();
        }
        static private GuideTBList list = new GuideTBList();

        public static GuideTBL SelectById(int id)
        {
            GuideDB db = new GuideDB();
            list = db.SelectAll();

            GuideTBL g = list.Find(item => item.Id == id);
            return g;
        }


        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GuideTBL gu = entity as GuideTBL;
            if (gu != null)
            {
                string sqlStr = $"DELETE FROM GuideTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", gu.Id));
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
            GuideTBL gu = entity as GuideTBL;
            if (gu != null)
            {
                string sqlStr = $"Insert INTO  GuideTBL (WhoWasInTrainingCourse) VALUES (@WhoWasInTrainingCourse)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@WhoWasInTrainingCourse", gu.WhoWasInTrainingCourse));
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
            GuideTBL gu = entity as GuideTBL;
            if (gu != null)
            {
                string sqlStr = $"UPDATE GuideTBL  SET WhoWasInTrainingCourse=@WhoWasInTrainingCourse WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@WhoWasInTrainingCourse", gu.WhoWasInTrainingCourse));
                command.Parameters.Add(new OleDbParameter("@id", gu.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            GuideTBL Guide = entity as GuideTBL;
            if (Guide != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
    }
}