using System;

namespace Exercicio3
{
    class Program
    {
        static int ContaNumerosImpares(int[] vetorInteiros)
        {
            int quantidadeImpares = 0;
            foreach (int numeroInteiro in vetorInteiros)
            {
                if (numeroInteiro % 2 != 0)
                {
                    quantidadeImpares++;
                }
            }
            return quantidadeImpares;
        }
        
        static void Main(string[] args)
        {
            int[] vetorInteiros = new int[20];
            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                Console.Write($"Digite o numero da posicao {i} do vetor: ");
                vetorInteiros[i] = int.Parse(Console.ReadLine());
            }

            int quantidadeImpares = ContaNumerosImpares(vetorInteiros);

            Console.WriteLine($"Numeros impares digitados no vetor: {quantidadeImpares}");
        }
    }
}
