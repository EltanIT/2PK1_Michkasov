using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_28
{
    class Wait
    {
        public delegate void MyDelegate(Wait wait);

        public event MyDelegate myEvent;

        public void seeWait(Wait wait) => myEvent.Invoke(wait);
        public int val;

        public Wait(int i)
        {
            val = i;
        }

        public void track()
        {
            myEvent += compare;
        }

        void compare(Wait obj)
        {
            switch (obj.val)
            {
                case 200:
                    Console.WriteLine("Значение достигло 200");
                    break;
                case 800:
                    Console.WriteLine("Значение достигло 800");
                    break;
            }
        }
    }
}
