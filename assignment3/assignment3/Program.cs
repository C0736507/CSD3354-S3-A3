﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessing();
            tp.Run();
        }
    }

    class TextProcessing
    {
        public void Run()
        {
            // Open the names file and access the data
            using (StreamReader file = new StreamReader("C:/Users/HP/Dropbox/Academic_Desk/ProgramCode/csharpSection12/Assignment-3/Assignment-3/names.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
    }

}
