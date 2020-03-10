using System;

namespace uri1165
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int teste = int.Parse(Console.ReadLine());
                int Div = 0;

                for (int j = 1; j <= teste; j++)
                {
                    if (teste % j == 0)
                    {
                        Div += 1;
                    }
                }

                if (Div == 2)
                {
                    Console.WriteLine(teste + " eh primo");
                }

                else
                {
                    Console.WriteLine(teste + " nao eh primo");
                }
            }
        }
    }
}
