using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    class Program
    {
        private static Listener listener;
        static void Main(string[] args)
        {
            listener = new Listener(8080);
            Console.WriteLine("Listening on port 8080 (http://localhost:8080/).");
            Console.WriteLine("Remember to put the files you want to serve in the output folder of the project.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
