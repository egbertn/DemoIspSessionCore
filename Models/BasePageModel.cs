using ispsession.io.core;
using ispsession.io.core.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace DemoISPSessionCore.Models
{
    public class BasePageModel : PageModel
    {
        public IISPSession Session
        {
            get
            {
                var features = HttpContext.Session();
                return features ??
                    throw new Exception("ISP Session Feature not found");
            }
        }

        public IApplicationCache Cache
        {
            get
            {
                var features = HttpContext.ApplicationCache();

                return features ??
                throw new Exception("ISP Cache Feature not found");
            }
        }
        public SomeCacheClass CachedData
        {
            get { return (SomeCacheClass)Cache["SomeCache"]; }
        }

    }
}
