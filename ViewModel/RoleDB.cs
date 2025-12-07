
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class RoleDB : BaseDB
    {
        public RoleTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM RoleTBL";
            RoleTBList groupList = new RoleTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            RoleTBL ro = entity as RoleTBL;
            ro.WhatRole = reader["WhatRole"].ToString();
            base.CreateModel(entity);
            return ro;
        }
        public override BaseEntity NewEntity()
        {
            return new RoleTBL();
        }
        static private RoleTBList list = new RoleTBList();

        public static RoleTBL SelectById(int id)
        {
            RoleDB db = new RoleDB();
            list = db.SelectAll();

            RoleTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            RoleTBL r = entity as RoleTBL;
            if (r != null)
            {
                string sqlStr = $"DELETE FROM RoleTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", r.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            RoleTBL r = entity as RoleTBL;
            if (r != null)
            {
                string sqlStr = $"Insert INTO  RoleTBL (WhatRole) VALUES (@WhatRole)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@WhatRole", r.WhatRole));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            RoleTBL r = entity as RoleTBL;
            if (r != null)
            {
                string sqlStr = $"UPDATE RoleTBL  SET WhatRole=@WhatRole WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@WhatRole", r.WhatRole));
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
            }
        }
    }
}





