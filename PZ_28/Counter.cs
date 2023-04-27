using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_28
{
    class Counter
    {
        public Wait wait = new Wait(0);

        public void method()
        {
            for (int i = 0; i <= 1000; i++)
            {
                wait.seeWait(new Wait(i));
            }
        }
    }
}
