using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Ping
    {
        public string pingHostPrint(ref string url) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            System.Diagnostics.Stopwatch timer = new Stopwatch();

            timer.Start();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            Console.Write("  Ping: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(timer.ElapsedMilliseconds + "ms");
            Console.ResetColor();

            if (timer.ElapsedMilliseconds == 1000) {
                Console.WriteLine("  Ping: R.I.P");
            }
            return string.Empty;
        }
    }
}
