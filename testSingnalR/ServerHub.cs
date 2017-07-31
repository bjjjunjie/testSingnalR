using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testSingnalR
{
    public class ServerHub:Hub
    {
        public  void SendMsg(string message)
        {
            //调用所有客户端的sendMessage方法(sendMessage有2个参数)  
         Clients.All.sendMessage(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), message);
        }
    }
}