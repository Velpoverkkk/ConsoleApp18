using System;
class Program
{   //Задана матрица размером NxM.Упорядочить её  строки по возрастанию  cуммы их элементов .
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, M, sum1=0,sum2=0, a;
        System.Console.WriteLine("Razmer massiva NxM");
        N = System.Convert.ToInt32(Console.ReadLine());
        M = System.Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, M];
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                array[j, k] = rnd.Next(0, 5);
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
        for (int k = 0; k < N * M*10; k++)
        {
            for (int i = 0; i < N - 1; i++)
            {   for(int j=0; j < M; j++)
                {
                    sum1 += array[i, j];
                    sum2 += array[i + 1, j];
                }
                if (sum1 > sum2)
                {

                    for (int j = 0; j < M; j++)
                    {
                        a = array[i, j];
                        array[i, j] = array[i + 1, j];
                        array[i + 1, j] = a;
                    }

                }
                sum1 = 0;
                sum2 = 0;
            }
        }
        System.Console.WriteLine();
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
    }

}
