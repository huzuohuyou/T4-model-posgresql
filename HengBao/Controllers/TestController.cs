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
using xiaoheng.pos.Model;
namespace HengBao.Controllers
{
    public class TestController : ApiController
    {
        private const string CONNECTION_STRING = "server=127.0.0.1;Port=5432;Database=postgres;uid=postgres;pwd=wozuishuai;Encoding=UNICODE";
        [HttpGet]
        [Route("Hello")]
        //怎们玩
        public Response Hello(int id)
        {
            try
            {
                
                Product p = new Product();
                IDbConnection conn = new NpgsqlConnection(CONNECTION_STRING);
                //var product = conn.Query<Product>("select * from product where name = @name", new { name = pname });
                var myShopProduct = conn.Query("select product.* from product ,shop where product.shopid = shop.id and shop.id = @id", new { id = id });
                //var result = conn.Execute("Insert into product values (@name, @price, @status)", new { name = pname, price = 998, status = false });
                //ExceptionlessClient.Default.Configuration.ApiKey = "fPsfg0YN82tzmlKt5LkLmGTeiD67wwV0EIopfzw4";
                ExceptionlessClient.Default.CreateLog("Hello", "local Exceptionless", LogLevel.Normal.ToString()).Submit();
                return new Response(myShopProduct);
            }
            catch (Exception ex)
            {
                ex.ToExceptionless().Submit();
                return new Response(ex).False();
            }
        }

        [HttpPost]
        [Route("Product")]
        //怎们玩
        public Response Product(Product p)
        {
            try
            {
                IDbConnection conn = new NpgsqlConnection(CONNECTION_STRING);
                var result = conn.Execute("Insert into product (name, price, status,url,shopid,kind) values (@name, @price, @status,@url,@shopid,@kind)", p);
                ExceptionlessClient.Default.CreateLog("Hello", "add product", LogLevel.Normal.ToString()).Submit();
                return new Response(result);
            }
            catch (Exception ex)
            {
                ExceptionlessClient.Default.CreateException(ex).Submit();
                return new Response(ex).False();
            }
        }
    }
}
