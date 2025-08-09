namespace Interfaces
{ 
public interface Imovable
    {
        void move();
    }
    //derived interface
    public class Car : Imovable
    {
        public void move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : Imovable
    {
        public void move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Imovable myCar = new Car();
            myCar.move();
            Imovable myBicycle = new Bicycle();
            myBicycle.move();
        }
    }

}