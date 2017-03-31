using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using xiaoheng.pos.Model;

namespace WebApplication1.Areas.Pos.Models
{
    public class Test
    {
        private const string CONNECTION_STRING = "server=127.0.0.1;Port=5432;Database=postgres;uid=postgres;pwd=wozuishuai;Encoding=UNICODE";
        public void Hello() {
            Product p = new Product();
            
            p.Name = "111";
            IDbConnection conn = new NpgsqlConnection(CONNECTION_STRING);
            var result = conn.Execute("Insert into product values (@name, @price, @status)", new { name = "jack", price = 998, status = false });
        }
    }
}