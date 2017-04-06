using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HengBao.Controllers
{
    public class Response
    {

        private static readonly String OK = "ok";
        private static readonly String ERROR = "error";

        public Meta meta { get; set; }
        public Object data { get; set; }

        public  Response(Object data,bool flag,string msg) {
            this.meta = new Meta(flag, msg);
            this.data = data;
        }

        public Response(Object data)
        {
            this.meta = new Meta(true, OK);
            this.data = data;
        }

        public Response()
        {
            this.meta = new Meta(true, OK);
            this.data = "success";
        }

        public Response False() {
            this.meta = new Meta(false, ERROR);
            return this;
        }

        public class Meta
        {

            public bool success { get; set; }
            public String message { get; set; }

            public Meta(bool success)
            {
                this.success = success;
            }

            public Meta(bool success, String message)
            {
                this.success = success;
                this.message = message;
            }

            
        }
    }
}