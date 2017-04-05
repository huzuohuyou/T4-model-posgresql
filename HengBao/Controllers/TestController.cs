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
        public Response Hello(string pname)
        {
            try
            {
                Product p = new Product();
                IDbConnection conn = new NpgsqlConnection(CONNECTION_STRING);
                var product = conn.Query<Product>("select * from product where name = @name", new { name = pname });
                var result = conn.Execute("Insert into product values (@name, @price, @status)", new { name = pname, price = 998, status = false });
                ExceptionlessClient.Default.Configuration.ApiKey = "epMiiNOWHM0XiM5Z60F4htA9agpFfd2pHrJ2WDnj";
                ExceptionlessClient.Default.CreateLog("Hello","Hello 我成功了!",LogLevel.Normal.ToString()).AddTags("exceptionless").Submit();
                return new Response(product.ToList<Product>());
            }
            catch (Exception ex)
            {

                ex.ToExceptionless().Submit();
                throw;
            }
           }
    }
}
