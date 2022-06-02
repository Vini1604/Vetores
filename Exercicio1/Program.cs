using System;

namespace Exercicio1
{
    class Program
    {
        static Pessoa[] Unir2Grupos(Pessoa[] grupo1, Pessoa[] grupo2)
        {
            int indiceGrupo1 = 0, indiceGrupo2 = 0;
            int tamanhoGrupoUnido = grupo1.Length + grupo2.Length;
           
            Pessoa[] grupoUnido = new Pessoa[tamanhoGrupoUnido];
            for (int i = 0; i < grupoUnido.Length; i++)
            {
                if (i % 2 == 0)
                {
                    grupoUnido[i] = grupo1[indiceGrupo1];
                    indiceGrupo1++;
                }
                else
                {
                    grupoUnido[i] = grupo2[indiceGrupo2];
                    indiceGrupo2++;
                }
            }
            return grupoUnido;
        }
        static void ImprimeGrupo(Pessoa[]grupo, string nomeGrupo)
        {
            Console.WriteLine("*********************************");
            Console.WriteLine(nomeGrupo);
            Console.WriteLine();
            foreach (var pessoa in grupo)
            {
                Console.WriteLine(pessoa);
            }
            Console.WriteLine("*********************************");

            Console.WriteLine();
        }
        static Pessoa[] CriarGrupos(string nomeGrupo)
        {
            Pessoa[] grupo = new Pessoa[10];
            string nome;
            int idade;
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine(nomeGrupo);
            for (int i = 0; i < grupo.Length; i++)
            {
                Console.Write($"Digite o nome da pessoa {i + 1}: ");
                nome = Console.ReadLine();
                Console.Write($"Digite a idade da pessoa {i + 1}: ");
                idade = int.Parse(Console.ReadLine());
                grupo[i] = new Pessoa(nome, idade);
            }
            Console.WriteLine("**********************************");
            Console.WriteLine();
            return grupo;
        }
        
        static void Main(string[] args)
        {

            Pessoa[] grupo1 = CriarGrupos("Grupo 1");
            Pessoa[] grupo2 = CriarGrupos("Grupo 2");
            Pessoa[] uniaoGrupos = Unir2Grupos(grupo1, grupo2);

            ImprimeGrupo(grupo1, "Grupo 1");
            ImprimeGrupo(grupo2, "Grupo 2");
            ImprimeGrupo(uniaoGrupos, "Grupo 1 e 2 Unidos");
            /* 
            foreach (var pessoa in grupo1)
            {
                Console.WriteLine(pessoa);
            }
            /*
            Console.WriteLine("***********************************");
            Console.WriteLine("Grupo 1:");
            for (int i = 0; i < grupo1.Length; i++)
            {
                Console.Write($"Digite o nome da pessoa {i + 1}: ");
                nome = Console.ReadLine();
                Console.Write($"Digite a idade da pessoa {i + 1}: ");
                idade = int.Parse(Console.ReadLine());
                grupo1[i] = new Pessoa(nome, idade);
            }
            Console.WriteLine("**********************************");
            Console.WriteLine();
            */
        }
    }
}
