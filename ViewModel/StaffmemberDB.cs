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
    public class StaffMemberDB : PersonDB
    {
        public StaffMemberTBList SelectAll()
        {
            command.CommandText = $"SELECT PersonTBL.*, StaffMemberTBL.RoleCode FROM(StaffMemberTBL INNER JOIN" +
                $" PersonTBL ON StaffMemberTBL.ID = PersonTBL.ID)";


            StaffMemberTBList groupList = new StaffMemberTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            StaffMemberTBL sm = entity as StaffMemberTBL;
            sm.RoleCode = RoleDB.SelectById((int)reader["RoleCode"]);
            base.CreateModel(entity);
            return sm;
        }
        public override BaseEntity NewEntity()
        {
            return new StaffMemberTBL();
        }
        static private StaffMemberTBList list = new StaffMemberTBList();

        public static StaffMemberTBL SelectById(int id)
        {
            StaffMemberDB db = new StaffMemberDB();
            list = db.SelectAll();

            StaffMemberTBL g = list.Find(item => item.Id == id);
            return g;
        }


        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            StaffMemberTBL sm = entity as StaffMemberTBL;
            if (sm != null)
            {
                string sqlStr = $"DELETE FROM StaffMemberTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", sm.Id));
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
            StaffMemberTBL sm = entity as StaffMemberTBL;
            if (sm != null)
            {
                string sqlStr = $"Insert INTO  StaffMemberTBL (Role) VALUES (@Role)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@Role", sm.RoleCode.Id));
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
            StaffMemberTBL sm = entity as StaffMemberTBL;
            if (sm != null)
            {
                string sqlStr = $"UPDATE StaffMemberTBL  SET RoleCode=@RoleCode WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@RoleCode", sm.RoleCode.Id));
                command.Parameters.Add(new OleDbParameter("@id", sm.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            StaffMemberTBL StaffMember = entity as StaffMemberTBL;
            if (StaffMember != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }
    }
}

