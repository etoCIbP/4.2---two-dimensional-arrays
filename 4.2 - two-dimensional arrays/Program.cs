using System;

namespace _4._2___two_dimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massiv1 = new int[30], massiv2 = new int[30], massiv3 = new int[30]; 
            Random random1 = new Random(), random2 = new Random(), random3 = new Random();
            //int[] massiv2 = new int[30];
            //Random random2 = new Random();

            for (int i = 0; i < 10; i++)

            {
                massiv1[i] = random1.Next(0, 9)*3*-1;   //Берутся числа от 0 до 9
                massiv2[i] = random2.Next(0, 9)*3*-1;   // Затем умножаются на 3
                massiv3[i] = random3.Next(0, 9)*3*-1;   // и далее умножаются на -1 для отрицательного числа
                if (massiv1[i] % 2 == 0)
                    Console.WriteLine("{0} Первый массив: ", massiv1[i]);
                //Console.WriteLine(" ");
                    Console.WriteLine("{0} Второй массив: ", massiv2[i]);
                //Console.WriteLine(" ");
                    Console.WriteLine("{0} Третий массив: ", massiv3[i]);
                //Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
