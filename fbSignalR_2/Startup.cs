using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;

[assembly: Microsoft.Owin.OwinStartup("teste", typeof(fbSignalR.Startup))]


namespace fbSignalR
{
        public class Startup
        {
            public void Configuration(IAppBuilder app)
            {
                app.MapSignalR<TrackerConnection>("/tracker");
            }
        }
}