using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Status
    {
        public string statusHostPrint(ref string url) {
            WebRequest webRequest = HttpWebRequest.Create(url);
            webRequest.Method = "HEAD";
            try
            {
                using (WebResponse webResponse = webRequest.GetResponse())
                {
                    Console.Write("  Status: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("success");
                    Console.ResetColor();
                }
            }
            catch 
            {
                Console.Write("  Status: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("failed");
                Console.ResetColor();
            }
            return url;
        }
    }
}
