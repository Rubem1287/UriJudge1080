using System;

namespace Uri1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int v,p;
            int[] vetor;
            v = 0;
            p = 0;
            vetor = new int[100];
            v = int.Parse(Console.ReadLine());

            for (int i = 0; i < 100; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
                int a = vetor[i];
                if(a >v)
                {
                    v = a;
                    p = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(v);
            Console.WriteLine();
            Console.WriteLine(p);
        }
    }
}
