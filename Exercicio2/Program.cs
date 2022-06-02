using System;

namespace Exercicio2
{
    class Program
    {
        static ValorExtremo EncontraMaior(int[] vetorInteiros)
        {
            int maiorNumero = vetorInteiros[0], indiceMaior = 0;
            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                if (vetorInteiros[i] > maiorNumero)
                {
                    maiorNumero = vetorInteiros[i];
                    indiceMaior = i;
                }
            }
            return new ValorExtremo() { IndiceDoNumero = indiceMaior, ValorDoNumero = maiorNumero };

        }

        static ValorExtremo EncontraMenor(int[] vetorInteiros)
        {
            int menorNumero = vetorInteiros[0], indiceMenor = 0;
            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                if (vetorInteiros[i] < menorNumero)
                {
                    menorNumero = vetorInteiros[i];
                    indiceMenor = i;
                }
            }
            return new ValorExtremo() { IndiceDoNumero = indiceMenor, ValorDoNumero = menorNumero };

        }

        static void Main(string[] args)
        {
            int[] vetorInteiros = new int[20];
            ValorExtremo maior, menor;

            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                Console.Write($"Insira um numero na posicao {i} do vetor: ");
                vetorInteiros[i] = int.Parse(Console.ReadLine());
            }
            menor = EncontraMenor(vetorInteiros);
            maior = EncontraMaior(vetorInteiros);
            Console.WriteLine($"Menor -> {menor}");
            Console.WriteLine($"Maior -> {maior}");
            
        }
    }
}
