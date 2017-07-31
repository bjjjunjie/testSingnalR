using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signalRclient
{
   public class TestHub : Hub
    {
        static TestHub()
        {
            Console.WriteLine("hello");
        }
        public override Task OnConnected()
        {
            Console.WriteLine(DateTime.Now.ToString("已连接") + ":" + Context.ConnectionId);
            Clients.Client(Context.ConnectionId).receive(DateTime.Now.ToString("已连接")+":"+ Context.ConnectionId);
            return base.OnConnected();
        }
        public void Send(string msg)
        {
            Console.WriteLine(("yyyy-MM-dd HH:mm:ss")+msg, DateTime.Now);
            Clients.All.receive(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msg);
        }
    }
}
