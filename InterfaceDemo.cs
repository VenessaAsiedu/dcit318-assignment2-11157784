using System;

namespace DCIT318_Assignment2
{
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    public static class InterfaceDemo
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Interfaces ---");

            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}
