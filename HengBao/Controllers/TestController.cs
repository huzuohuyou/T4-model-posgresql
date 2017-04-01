using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dapper;
using xiaoheng.pos.Model;
using Exceptionless;
namespace HengBao.Controllers
{
    public class TestController : ApiController
    {
        private const string CONNECTION_STRING = "server=127.0.0.1;Port=5432;Database=postgres;uid=postgres;pwd=wozuishuai;Encoding=UNICODE";
        [Route("Hello")]
        //怎们玩
        public bool Hello(string pname)
        {
            try
            {
                Product p = new Product();

                p.Name = "111";
                IDbConnection conn = new NpgsqlConnection(CONNECTION_STRING);
                var result = conn.Execute("Insert into product values (@name, @price, @status)", new { name = pname, price = 998, status = false });
                //HttpConfiguration config = new HttpConfiguration();
                //ExceptionlessClient.Default.RegisterWebApi(config);
                //ExceptionlessClient.Default.RegisterWebApi(GlobalConfiguration.Configuration);
                ExceptionlessClient.Default.CreateLog("Hello","Hello El!",LogLevel.Normal.ToString()).AddTags("exceptionless").Submit();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
           }
    }
}
