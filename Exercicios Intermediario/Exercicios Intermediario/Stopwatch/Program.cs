using System;
using System.Threading;

namespace Exercicios_Intermediario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var keepGoing = true;
            var stopwatch = new Stopwatch();


            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            while (keepGoing)
            {
                var statusString = "Waiting";

                if (stopwatch.IsRunning)
                    statusString = $"Running [{stopwatch.LastTime}]";
                else if (stopwatch.LastTime != null)
                    statusString = stopwatch.LastTime.ToString();


                Console.Clear();
                Console.WriteLine($"Stopwatch ({statusString})\n" +
                    $"Type:\n" +
                    $"B and ENTER - to begin the stopwatch\n" +
                    $"S and ENTER - to stop the stopwatch\n" +
                    $"A number and ENTER - to wait for that number in milliseconds\n" +
                    $"ENTER - to refresh\n" +
                    $"Q and ENTER - to quit the stopwatch");

                var option = Console.ReadLine().ToLower();

                switch (option)
                {
                    case "b":
                        stopwatch.Start();

                        break;
                    case "s":
                        stopwatch.Stop();

                        break;
                    case "":
                        //refresh

                        break;
                    case "q":
                        keepGoing = false;

                        break;
                    default:
                        if (int.TryParse(option, out var intOption))
                            stopwatch.Wait(intOption);

                        break;
                }
            }

            stopwatch2.Stop();
            Console.WriteLine($"Running app for: {stopwatch2.LastTime}");
            ConsoleUtils.WaitKey();
        }
    }

    public class Stopwatch
    {
        private DateTime? _startTime;
        public bool IsRunning;

        private TimeSpan? _lastTime;
        public TimeSpan? LastTime
        {
            get
            {
                if (!IsRunning)
                    return _lastTime;

                _lastTime = DateTime.Now - _startTime.Value;

                return _lastTime;
            }
        }

        public void Start()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                _startTime = DateTime.Now;
            }
            else
            {
                Console.WriteLine("The system is already counting time");
                ConsoleUtils.WaitKey();

                return;
            }
        }

        public void Stop()
        {
            if (!IsRunning)
            {
                Console.WriteLine("Can't stop if it aint started, dummy.");
                ConsoleUtils.WaitKey();

                return;
            }

            IsRunning = false;
            _lastTime = DateTime.Now - _startTime.Value;
        }

        public void Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
    }

    public static class ConsoleUtils
    {
        public static void WaitKey()
        {
            Console.WriteLine("Press anything to continue...");
            Console.ReadKey();
        }
    }
}