using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;


[assembly: OwinStartup(typeof(testSingnalR.Startup))]
namespace testSingnalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 配置集线器  
            app.MapSignalR();

          
        }
       
    }
}