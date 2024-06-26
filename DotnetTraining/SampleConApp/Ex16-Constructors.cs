using System;
/*
 * Constructor is a concept which works like functions but are invoked when the object is instantiated. 
 * Constructors are mainly required to inject the dependencies of UR class, so that the object could be used without any additional settings or statements to call. 
 * Construtors are like methods, they can be overloaded. 
 * Constructors with no parameters are called Default constructors. 
 * U can also have static constructors.
 * static constructors are similar to static blocks in Java. Here, it is used to set injectors to the static members of the class. They cannot have parameters. They cannot be explicitly invoked. It is automatically invoked when the first reference of the class is made in the program. It is called once and only once during the execution of the program
 */
namespace SampleConApp
{
    class SampleClass
    {
        public static int StaticVariable;
        public int NonStaticVariable;
        //Static Constructor
        static SampleClass()
        {
            StaticVariable = 123;
            Console.WriteLine("Static Constructor is called");
        }

        public SampleClass(int variable)
        {
            NonStaticVariable = variable;
            Console.WriteLine("Instance Constructor is called");
        }
    }
    public class Infotainment
    {
        public string Instrument { get; set; }
        public void Play() => Console.WriteLine($"{Instrument} is now playing");
    }

    class Car
    {
        public Car(string regNo, int capacity, Infotainment instrument)
        {
            Regno = regNo;
            Capacity = capacity;
            Navigator = instrument;
        }

        public string Regno { get; set; }
        public int Capacity { get; set; } = 1000; 
        public Infotainment Navigator { get; set; }

        public void RunCar()
        {
            Console.WriteLine("The Car Engine has started.");
            Navigator.Play();   
        }
    }
    internal class Ex16Constructors
    {
        static void Main(string[] args)
        {
            //Car car = new Car("KA41MB9460", 1200, new Infotainment { Instrument = "JBL" });
            //car.RunCar();

            SampleClass cls = new SampleClass(123);
            cls = new SampleClass(456);
            cls = new SampleClass(456);
            cls = new SampleClass(456);
            cls = new SampleClass(456);
            cls = new SampleClass(456);
            cls = new SampleClass(456);
            cls = new SampleClass(456);
            cls = new SampleClass(456);
            SampleClass.StaticVariable = 456567;
        }
    }
}
