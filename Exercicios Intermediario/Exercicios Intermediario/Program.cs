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
            Stopwatch start;
            Stopwatch stop;


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
                        start = Stopwatch.Start();

                        Console.WriteLine("Start: " + start);
                        isCounting = true;
                    }
                }
                else if (lowerOption == "s")
                {


                    if (isCounting)
                    {
                        
                        
                        stop = Stopwatch.Stop();
                        Console.WriteLine("Stop: " + stop);
                        isCounting = false;

                        var duration = new Stopwatch();
                        Console.WriteLine("Duration: " + duration.Duration.ToString("c"));

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
        public DateTime Begin;
        public DateTime End;





    //    public static Stopwatch Start()
    //    {                       
    //        var start = new Stopwatch();
    //        start.Begin = DateTime.Now;
    //        return start;
    //    }
    //    public static Stopwatch Stop() 
    //    {                        
    //        var stop = new Stopwatch();
    //        stop.End = DateTime.Now;
    //        return stop;
    //    }

    //    public static Stopwatch Duration()
    //    {
    //        var duration = End - Begin;
    //        int toInt = Convert.ToInt32(duration.Seconds);
    //        return duration;
    //    }
    //}

    







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
