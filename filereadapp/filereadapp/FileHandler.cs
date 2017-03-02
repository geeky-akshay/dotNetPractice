using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filereadapp
{
    class FileHandler
    {
        public string File { get; private set; }

        public void PerformFileOpertaions(string[] args)
        {
            switch (args.Length)
            {
                case 2:
                    {
                        string operation = args[0];
                        File = args[1];
                        ReadOrCreateFile(operation: operation);
                        break;
                    }

                case 3:
                    {
                        File = args[2];

                        if (args[0] == "-n" && args[1] == "-r")
                        {
                            ReadAndCountCharacters();
                        }
                        else
                        {
                            Console.WriteLine("invalid operation");
                        }
                        break;
                    }

                case 4:
                    {
                        File = args[3];
                        string text = args[1];

                        if (args[0] == "-t" && args[2] == "-w")
                        {
                            WriteToFile(textToWrite: text);
                        }
                        else
                        {
                            Console.WriteLine("invalid operation");
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("invalid operation. exiting...");
                        break;
                    }
            }
        }

        void ReadOrCreateFile(string operation)
        {
            if (operation == "-r")
            {
                Console.WriteLine(System.IO.File.ReadAllText(File));
            }
            else if (operation == "-w")
            {
                System.IO.File.Create(File);
                Console.WriteLine($"Created file {File}...");
            }
            else
            {
                Console.WriteLine("invalid operation");
            }
        }

        void ReadAndCountCharacters()
        {
            Console.WriteLine(System.IO.File.ReadAllText(File));
            var noOfCharacters = System.IO.File.ReadAllText(File).ToCharArray().Count();
            Console.WriteLine("\n\nNo of characters in file : {0}", noOfCharacters);
        }

        void WriteToFile(string textToWrite)
        {
            if (System.IO.File.Exists(File))
            {
                System.IO.File.WriteAllText(File, textToWrite);
            }
            else
            {
                System.IO.File.Create(File);
                System.IO.File.WriteAllText(File, textToWrite);
            }
        }
    }
}
