using System.Web.Http.Filters;
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Net.Http.Headers;  
using System.Web;  


namespace Ivar.Controllers
{
    public class Cachefilter:ActionFilterAttribute
    {
        public int TimeDuration { get; set; }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue
            {
                MaxAge = TimeSpan.FromSeconds(TimeDuration),
                MustRevalidate = true,
                Public = true
            };
        }
    }
}