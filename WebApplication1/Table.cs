using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// 数据库中的表
    /// </summary>
    public class Table
    {
        string name;

        public void Test()
        {
            string connectionString = "server=127.0.0.1;Port=5432;Database=wos;uid=postgres;pwd=wozuishuai;Encoding=UNICODE";
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                
                conn.Open();
                string selectQuery = "SELECT   tablename   FROM   pg_tables   WHERE   tablename   NOT   LIKE   'pg%'   AND tablename NOT LIKE 'sql_%' ORDER   BY   tablename; ";
                NpgsqlCommand cmd = new NpgsqlCommand(selectQuery, conn);
                var tables = cmd.ExecuteScalar();
               
            }
        }
    }

    /// <summary>
    /// 表对应的结构
    /// </summary>
    public class Column
    {
        string field;
        string type;
        int length;
        int lengthvar;
        string notnull;
    }
}