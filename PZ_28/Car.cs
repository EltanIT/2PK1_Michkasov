using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PZ_28
{
    class Car
    {
        public patrolman patrolman1 = new patrolman(0);

        public void method()
        {
            for (int i = 0; i <= 200; i++)
            {
                Thread.Sleep(80);
                if (i % 10 == 0)
                {
                    Console.WriteLine($"скорость: {i}км/ч");
                }
                patrolman1.seeWait(new patrolman(i));
                
            }
        }
    }
}
