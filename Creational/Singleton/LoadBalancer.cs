using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Creational.Singleton
{
    public class LoadBalancer
    {
        // static 屬性會在服務剛啟動時，提早初始化。
        // 所以以下的寫法.NET 可以確保只有一個instance
        private static readonly LoadBalancer _instance = new LoadBalancer();
        private readonly List<Server> _servers;
        Random _random = new Random();

        protected LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ Name = "Server 1", IP = "120.14.220.18" },
                new Server{ Name = "Server 2", IP = "120.14.220.19" },
                new Server{ Name = "Server 3", IP = "120.14.220.20" },
                new Server{ Name = "Server 4", IP = "120.14.220.21" },
                new Server{ Name = "Server 5", IP = "120.14.220.22" },
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return _instance;
        }

        public Server NextServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }

    public class Server
    {
        public string Name { get; set; }
        public string IP { get; set; }
    }
}
