using System.Collections.Generic;

namespace proxifyre_tray
{
    public class Configuration
    {
        public class Proxy
        {
            public List<string> appNames;
            public string socks5ProxyEndpoint;
            public string username;
            public string password;
            public List<string> supportedProtocols;
        }

        public string logLevel;
        public List<Proxy> proxies;
    }
}
