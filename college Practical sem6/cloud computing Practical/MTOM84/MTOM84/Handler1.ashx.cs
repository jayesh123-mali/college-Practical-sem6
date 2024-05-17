using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTOM84
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            MTOM84 ws = new MTOM84();
            byte[] binImage = ws.GetImageFile(context.Request["fileName"]);
            if (binImage.Length == 1)
            {
                //do nothing
            }
            else
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write("Hello World");
            }
            if (binImage.Length == 1)
            {
                //do nothing
            }
            else
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write("Hello World");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
