using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class IP
    {
        public string ipHostPrint(ref string url) {
            Uri myUri = new Uri(url.ToString());
            var ip = Dns.GetHostAddresses(myUri.Host)[0];
            Console.WriteLine("  IP: " + ip);
            return Convert.ToString(ip);
        }
    }
}
