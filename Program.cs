namespace Abstraction_Interfaces4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveCar(new GasCar());
            DriveCar(new ElectricCar());
        }

        static void DriveCar(ICar car)
        {
            car.StartEngine();
            // Code to drive the car
            car.StopEngine();
        }

    }

    public interface ICar
    {
        void StartEngine();
        void StopEngine();
    }
    public class GasCar : ICar
    {
        public void StartEngine()
        {
            Console.WriteLine("Starting gas engine");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping gas engine");
        }
    }
    public class ElectricCar : ICar
    {
        public void StartEngine()
        {
            Console.WriteLine("Starting electric engine");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping electric engine");
        }
    }



}
