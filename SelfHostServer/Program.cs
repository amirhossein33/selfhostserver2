using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHostServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:5001");
            config.Routes.MapHttpRoute("default", "api/{controller}/{id}");
            HttpSelfHostServer httpSelfHostServer = new HttpSelfHostServer(config);
            httpSelfHostServer.OpenAsync().Wait();
            Console.ReadLine();
        }
    }
}
