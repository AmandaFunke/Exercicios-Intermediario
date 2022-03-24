using System;


namespace Exercicios_Intermediario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch\nType:\nB and ENTER - to begin the stopwatch\nS and ENTER - to stop the stopwatch\nQ and ENTER - to quit the stopwatch");

            var keepGoing = true;
            var isCounting = false;
            //DateTime start;
            //DateTime stop;


            while (keepGoing)
            {
                var option = Console.ReadLine();
                var lowerOption = option.ToLower();

                if (lowerOption == "q")
                {
                    keepGoing = false;
                }
                else if (lowerOption == "b")
                {

                    if (isCounting)
                    {
                        Console.WriteLine("The system is already counting time");
                    }
                    else
                    {
                        var start = new Stopwatch();

                        Console.WriteLine("Start: " + start);
                        isCounting = true;
                    }
                }
                else if (lowerOption == "s")
                {


                    if (isCounting)
                    {
                        
                        
                        var stop = new Stopwatch();
                        Console.WriteLine("Stop: " + stop);
                        isCounting = false;

                        var duration = new Stopwatch();
                        Console.WriteLine("Duration: " + duration.Duration.ToString());

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
        public void Start()
        {
            var start = DateTime.Now;
        }
        public void Stop() 
        {
            var stop = DateTime.Now;
        }

        public int Duration
        {
            get 
            {
                DateTime start = Start();
                DateTime stop = Stop();
                var duration = stop - start;
                int toInt = Convert.ToInt32(duration.Seconds);
                return toInt;
            }
        }
    }

    







    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Stopwatch\nType:\nB and ENTER - to begin the stopwatch\nS and ENTER - to stop the stopwatch\nQ and ENTER - to quit the stopwatch");

    //        var keepGoing = true;
    //        var isCounting = false;

    //        while (keepGoing)
    //        {
    //            var option = Console.ReadLine();
    //            var lowerOption = option.ToLower();

    //            if (lowerOption == "q")
    //            {
    //                keepGoing = false;
    //            }
    //            else if (lowerOption == "b")
    //            {
    //                var start = new Stopwatch();
    //                start.Start();
    //                Console.WriteLine(start.Begin);

    //                if (isCounting)
    //                {
    //                    Console.WriteLine("The system is already counting time");
    //                }
    //                else
    //                {
    //                    DateTime start = DateTime.Now;
    //                    Console.WriteLine("Begin: " + start.ToString());
    //                    counting = true;
    //                }
    //            }
    //            else if (lowerOption == "s")
    //            {


    //                if (isCounting)
    //                {
    //                    DateTime stop = DateTime.Now;
    //                    Console.WriteLine("Stop: " + stop.ToString());
    //                    isCounting = false;

    //                }
    //                else
    //                {
    //                    Console.WriteLine("You can't stop counting time without starting");
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine("Invalid option");
    //            }
    //        }
    //    }
    //}

    //public class Stopwatch
    //{
    //    public bool isCounting = false;
    //    public DateTime Begin { get; set; }
    //    public DateTime End { get; set; }

    //    public void Start()
    //    {
    //        if (isCounting)
    //        {
    //            throw new ArgumentException("Start", "You can't start counting time when the system is already counting time");
    //        }
    //        else
    //        {
    //            Begin = DateTime.Now;
    //            isCounting = true;
    //        }
    //    }

    //    public void Stop()
    //    {
    //        if (isCounting)
    //        {
    //            End = DateTime.Now;
    //            isCounting = false;
    //        }
    //        else
    //        {
    //            throw new ArgumentException("Stop", "You can't stop counting time without starting");
    //        }
    //    }
    //}
}
