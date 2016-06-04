using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace goal._.listsndarrayprog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            string [] myarray = new String[5];
            Random myGen = new Random();
            Stopwatch mystopwatch = new Stopwatch();
            Stopwatch thestopwatch = new Stopwatch();
            mystopwatch.Start();

            for (int i = 0; i < 1000; i++ )
            {

                mylist.Add(myGen.Next(100, 1000));
            }



            if (mylist.Count != 100)
                {
                    int listSum = mylist.Sum();
                    Console.WriteLine("sum of my list {0}", listSum);
                }

               
            mystopwatch.Stop();

            Console.WriteLine(".......................................");
            thestopwatch.Start();

            myarray[0] = "dog";
            myarray[1] = "lion";
            myarray[2] = "elephant";
            myarray[3] = "horse";
            myarray[4] = "cat";
       

            for (int i = 0; i <= 4; i++ )
            {
                Console.WriteLine("animal   {0}",  myarray[i]);
            }

           
            thestopwatch.Stop();
            Console.WriteLine("the program finished in {0}", mystopwatch.ElapsedMilliseconds);
            Console.WriteLine("the program finished in {0}", thestopwatch.ElapsedMilliseconds);



            Console.ReadLine();
           
        }
     
    }
}
