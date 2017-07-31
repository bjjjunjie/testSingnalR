using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;

namespace signalRclient
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:7799";
            using (WebApp.Start(url))
            {
                Console.ReadLine();
            }
        }
    }
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HubConfiguration
            {
                EnableJSONP = true,
                EnableDetailedErrors = true,
                EnableJavaScriptProxies = true

            };
            app.UseCors(CorsOptions.AllowAll);
            // 配置集线器  
            app.MapSignalR();


        }

    }
}
