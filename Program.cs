using System;

namespace CarHomework
{
    class Program
    {

        public static void Main(string[] args)
        {
            var car = new car();
            var SaloonCar = new SaloonCar();
            var SaloonCar1 = new SaloonCar1(4.ToString());
            var SaloonCar2 = new SaloonCar2(4.ToString(), "Nissan");
            var SaloonCar3 = new SaloonCar3(4.ToString(), "Ford", "Purple");
            SaloonCar.NumberOfSeats = "3";
            Console.WriteLine("car 1 is " + car.color);
            Console.WriteLine("The Saloon Car is " + SaloonCar.color + " And has this many seats " + SaloonCar.NumberOfSeats);
            Console.WriteLine("SaloonCar1 has this many seats " + SaloonCar1.seats);
            Console.WriteLine("SaloonCar2 has " + SaloonCar2.seats + " seats and is made by" + SaloonCar2.manufactuer);
            Console.WriteLine("SaloonCar3 has "+ SaloonCar3.seats + " seats is made by " + SaloonCar3.manufactuer + " and its color is " + SaloonCar3.color);
        }
    }
    public class car
    {
        public car() 
        {
            this.color = "red";
            this.manufactuer = "toyota";
        }
        public string color {get; set;}
        public string manufactuer {get; set;}
    }
    public class SaloonCar : car
    {
        public SaloonCar()
        {
        }
        public string NumberOfSeats {get; set;}
    }
    public class SaloonCar1 : car
    {
        
        public string seats {get; set;}
        public SaloonCar1(string _Seats)
        {
            this.seats = _Seats;
        }
    }
    public class SaloonCar2
    {
        public string seats {get; set;}

        public string manufactuer {get; set;}

        public SaloonCar2(string _seats, string _manufactuer)
        {
            this.seats = _seats;
            this.manufactuer = _manufactuer;
        }
    }
    public class SaloonCar3
    {
        public string seats {get; set;}
        public string manufactuer {get; set;}
        
        public string color {get;set;}

        public SaloonCar3(string _seats, string _manufactuer, string _color)
        {
            this.seats = _seats;
            this.manufactuer = _manufactuer;
            this.color = _color;
        }
    }
}
