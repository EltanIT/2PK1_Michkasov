using System;

namespace PZ_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Вариант");
            Counter counter = new Counter();
            counter.wait.track();
            counter.method();

            Console.WriteLine("3 Вариант");
            Car car = new Car();
            car.patrolman1.track();
            car.method();

        }
    }
}
