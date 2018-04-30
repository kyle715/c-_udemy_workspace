using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var dozer = new BullDozer();
            dozer.color = "yellow";
            dozer.size = "tiny";
            Console.WriteLine("The Bulldozer is " + dozer.color);
        }
    }
    public class BullDozer
    {
        public string color { get; set;}
        public string size { get; set;}
    }
}
