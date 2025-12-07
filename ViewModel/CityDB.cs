
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace ViewModel
{
    public class CityDB : BaseDB
    {
        public CityTBList SelectAll()
        {
            command.CommandText = $"SELECT * FROM CityTBL";
            CityTBList groupList = new CityTBList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            CityTBL ct = entity as CityTBL;
            ct.WhatCity = reader["cityname"].ToString();
            base.CreateModel(entity);
            return ct;
        }
        public override BaseEntity NewEntity()
        {
            return new CityTBL();
        }
        static private CityTBList list = new CityTBList();

        public static CityTBL SelectById(int id)
        {
            CityDB db = new CityDB();
            list = db.SelectAll();

            CityTBL g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            CityTBL c = entity as CityTBL;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM CityTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            CityTBL c = entity as CityTBL;
            if (c != null)
            {
                string sqlStr = $"Insert INTO CityTBL (cityname) VALUES (@cityname)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cityname", c.WhatCity));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            CityTBL c = entity as CityTBL;
            if (c != null)
            {
                string sqlStr = $"UPDATE CityTBL  SET CityName=@cName WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.WhatCity));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
