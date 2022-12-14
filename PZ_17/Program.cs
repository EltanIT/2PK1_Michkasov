using System;

namespace PZ_17
{
    class Program
    {
       unsafe static void Main(string[] args)
        {
            double Double = 10;
            double* p = &Double;
            int DoubleAdress = (int)p;

            string result = DoubleAdress.ToString();
            char[] resChar = result.ToCharArray();

            Console.WriteLine(DoubleAdress);

            byte[] Byte = new byte[result.Length];


            for (int i = 0; i < Byte.Length; i++)
            {
                fixed(byte* tt = Byte)
                {
                    tt[i] = (byte)resChar[i];
                }
            }
            Console.WriteLine((byte)Byte[0]); 

        }
    }
}
