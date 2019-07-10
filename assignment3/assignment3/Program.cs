using System;
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
            //var tp = new TextProcessing();
            //tp.Run();
             
            new Blue().SayFavouriteFood(Red.FavouriteFood);
        }
    }

    class TextProcessing
    {
        Queue<string> names = new Queue<string>();
        public void Run()
        {
            // Open the names file and access the data
            using (StreamReader file = new StreamReader("U:/Users/736507/assignment3/assignment3/assignment3/TextFile1.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    names.Enqueue(ln);
                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                //post condition of while
                playingWithStacks.Run(names);
            }
        }
    }
    class playingWithStacks
    {
        public static void Run(Queue<string> tangerine)
        {
            Stack<string> names = new Stack<string>();
            //how can i access the queue variable "names" in this class
            //iterate over queue
            //get each element
            //push into stack
            foreach (var item in tangerine)
            {
                names.Push(tangerine.Dequeue());

            }



        }
    }
    class Workbench
    {

    }

    class Red
    {
        public static String FavouriteFood = "carrot";
    }

    class Blue
    {
        public void SayFavouriteFood(String FavouriteFood)
        {
            Console.WriteLine(Red.FavouriteFood);
        }
    }

}
