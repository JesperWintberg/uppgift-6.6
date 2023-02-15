using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Ord();
        }

        static void Ord()
        {
            Console.Write("skriv in en mening: ");
            string mening = Console.ReadLine();

            string[] mening2 = mening.Split(" ");

            for (int i = 0; i < mening2.Length; i++)
            {
                if (i % 2 == 0)
                {
                    mening2[i] = mening2[i].ToUpper();

                }

            }
            for (int j = 0; j < mening2.Length; j++)
            {
                Console.Write($" {mening2[j]}");
            }
        }

    }
}

