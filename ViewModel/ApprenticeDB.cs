using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;


namespace ViewModel
{
    public class ApprenticeDB:PersonDB
    {
        public ApprenticeTBList SelectAll()
        {
            command.CommandText = $"SELECT PersonTBL.*, ApprenticeTBL.School, ApprenticeTBL.Grade " +
                $"FROM(ApprenticeTBL INNER JOIN PersonTBL ON ApprenticeTBL.ID = PersonTBL.ID)";
            ApprenticeTBList groupList = new ApprenticeTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            ApprenticeTBL br = entity as ApprenticeTBL; 
            br.Grade = GradeDB.SelectById((int)reader["Grade"]);
            br.School = SchoolDB.SelectById((int)reader["School"]);
            base.CreateModel(entity);
            return br;
        }
        public override BaseEntity NewEntity()
        {
            return new ApprenticeTBL();
        }
        static private ApprenticeTBList list = new ApprenticeTBList();

        public static ApprenticeTBL SelectById(int id)
        {
            ApprenticeDB db = new ApprenticeDB();
            list = db.SelectAll();

            ApprenticeTBL g = list.Find(item => item.Id == id);
            return g;
        }


        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ApprenticeTBL ap = entity as ApprenticeTBL;
            if (ap != null)
            {
                string sqlStr = $"DELETE FROM ApprenticeTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", ap.Id));
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
            ApprenticeTBL ap = entity as ApprenticeTBL;
            if (ap != null)
            {
                string sqlStr = $"Insert INTO  ApprenticeTBL (School,Grade) VALUES (@School,@Grade)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@School", ap.School.Id));
                command.Parameters.Add(new OleDbParameter("@Grade", ap.Grade.Id));
            }
        }
        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity =this.NewEntity();
            if (entity != null& entity.GetType() == reqEntity.GetType()) 
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL,entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }


        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            ApprenticeTBL ap = entity as ApprenticeTBL;
            if (ap != null)
            {
                string sqlStr = $"UPDATE ApprenticeTBL  SET School=@School, Grade=@Grade WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@School", ap.School.Id));
                command.Parameters.Add(new OleDbParameter("@Grade", ap.Grade.Id));
                command.Parameters.Add(new OleDbParameter("@id", ap.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            ApprenticeTBL Apprentice = entity as ApprenticeTBL;
            if (Apprentice != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

    }
}
