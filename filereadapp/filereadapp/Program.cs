using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filereadapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check whether command line arguments are null or not
            if (args.Length < 2 || args.Length > 4)
            {
                Console.WriteLine("Please specify correct options.");
            }
            else
            {
                try
                {
                    FileHandler fileHandler = new FileHandler();
                    fileHandler.PerformFileOpertaions(args);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}
