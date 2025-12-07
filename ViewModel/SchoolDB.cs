
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class SchoolDB : BaseDB
    {
        public SchoolTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM SchoolTBL";
            SchoolTBList groupList = new SchoolTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            SchoolTBL sc = entity as SchoolTBL;
            sc.WhatSchool = reader["WhatSchool"].ToString();
            base.CreateModel(entity);
            return sc;
        }
        public override BaseEntity NewEntity()
        {
            return new SchoolTBL();
        }
        static private SchoolTBList list = new SchoolTBList();

        public static SchoolTBL SelectById(int id)
        {
            SchoolDB db = new SchoolDB();
            list = db.SelectAll();

            SchoolTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SchoolTBL s = entity as SchoolTBL;
            if (s != null)
            {
                string sqlStr = $"DELETE FROM SchoolTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", s.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SchoolTBL s = entity as SchoolTBL;
            if (s != null)
            {
                string sqlStr = $"Insert INTO  SchoolTBL (WhatSchool) VALUES (@WhatSchool)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@WhatSchool", s.WhatSchool));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            SchoolTBL s = entity as SchoolTBL;
            if (s != null)
            {
                string sqlStr = $"UPDATE SchoolTBL  SET WhatSchool=@WhatSchool WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@WhatSchool", s.WhatSchool));
                command.Parameters.Add(new OleDbParameter("@id", s.Id));
            }
        }





    }
}
