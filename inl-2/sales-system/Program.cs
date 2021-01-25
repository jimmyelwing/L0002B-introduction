using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using sales_system;

namespace sale_system
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new SalesSystemApplication();
            app.Run();

            Console.ReadKey();
        }
    }
}
