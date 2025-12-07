
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class GradeDB : BaseDB
    {
        public GradeTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM GradeTBL";
            GradeTBList groupList = new GradeTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            GradeTBL gr = entity as GradeTBL;
            gr.WhatGrade = reader["WhatGrade"].ToString();
            base.CreateModel(entity);
            return gr;
        }
        public override BaseEntity NewEntity()
        {
            return new GradeTBL();
        }
        static private GradeTBList list = new GradeTBList();

        public static GradeTBL SelectById(int id)
        {
            GradeDB db = new GradeDB();
            list = db.SelectAll();

            GradeTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GradeTBL g = entity as GradeTBL;
            if (g != null)
            {
                string sqlStr = $"DELETE FROM GradeTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", g.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GradeTBL g = entity as GradeTBL;
            if (g != null)
            {
                string sqlStr = $"Insert INTO  GradeTBL (WhatGrade) VALUES (@WhatGrade)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@WhatGrade", g.WhatGrade));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GradeTBL g = entity as GradeTBL;
            if (g != null)
            {
                string sqlStr = $"UPDATE GradeTBL  SET WhatGrade=@WhatGrade WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@WhatGrade", g.WhatGrade));
                command.Parameters.Add(new OleDbParameter("@id", g.Id));
            }
        }

         
        


    }
}
