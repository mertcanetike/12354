using System;

namespace arrays_9._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[5];

            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;
            sayilar[4] = 40;
            

            for (int i = 0; i<sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }


        }
    }
}
