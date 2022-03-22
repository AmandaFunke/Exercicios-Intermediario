using System;


namespace Exercicios_Intermediario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch\nType:\nB and ENTER - to begin the stopwatch\nS and ENTER - to stop the stopwatch\nQ and ENTER - to quit the stopwatch");
            
            var keepGoing = true;
            var counting = false;

            while (keepGoing)
            {
                var option = Console.ReadLine();
                var lowerOption = option.ToLower();
                
                if (lowerOption == "q")
                {
                    keepGoing = false;
                }
                else if(lowerOption == "b")
                {
                    if (counting)
                    {
                        Console.WriteLine("The system is already counting time");
                    }
                    else
                    {
                        DateTime start = DateTime.Now;
                        Console.WriteLine("Begin: " + start.ToString());
                        counting = true;
                    }                    
                }
                else if (lowerOption == "s")
                {
                    if (counting)
                    {
                        DateTime stop = DateTime.Now;
                        Console.WriteLine("Stop: " + stop.ToString());
                        counting = false;
                        
                    }
                    else
                    {
                        Console.WriteLine("You can't stop counting time without starting");
                    }                    
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
        }
    }

    public class Stopwatch
    {
        public void Start(DateTime start)
        {

        }

        public void Stop(DateTime stop)
        {

        }
    }
}
