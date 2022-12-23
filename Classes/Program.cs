namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Setting values for a new instance of the car class and printing them to the console. 
            var newCar = new Car();

            newCar.Make = "Honda";

            newCar.Model = "Civic";

            newCar.Year = 2000;

            Console.WriteLine($"My first car was a {newCar.Year} {newCar.Make} {newCar.Model}."); 
        }
    }
}
