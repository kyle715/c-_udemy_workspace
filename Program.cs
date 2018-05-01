using System;

namespace Bulldozer
{
    class Program
    {

        public static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.count(4);
            worker.count(5);
        }
    }
    public class FactoryWorker
    {
        public FactoryWorker ()
        {

        }
        public void count (int number)
        {
            if(Total == null)
            Total = 0;

            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }

        public int Total {get; set;}
    }
}
