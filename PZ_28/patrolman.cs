using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_28
{
    class patrolman
    {
        public delegate void MyDelegate(patrolman patrolman1);

        public event MyDelegate myEvent;

        public void seeWait(patrolman patrolman1) => myEvent.Invoke(patrolman1);
        public int val;

        public patrolman(int i)
        {
            val = i;
        }

        public void track()
        {
            myEvent += compare;
        }

        void compare(patrolman obj)
        {
            switch (obj.val)
            {
                case 80:
                    Console.WriteLine("Ваша скорость превысила 80км/ч!! СНИЗЬТЕ СКОРОСТЬ");
                    break;
                case 120:
                    Console.WriteLine("Ведем преследование за нарушителем, нарушавший закон со скоростью 120км/ч!!");
                    break;
            }
        }
    }
}
