using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushupConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BrushupWorker worker = new BrushupWorker();
            worker.Start();

            Console.ReadLine();

        }
    }
}
