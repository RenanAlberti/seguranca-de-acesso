using System;
using System.Threading;

class Operacoes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao Menu! Selecione uma das opcoes abaixo:");
        Console.WriteLine("1 - Selecione 1 para Adicao.");
        Console.WriteLine("1 - Selecione 2 para Subtracao.");
        Console.WriteLine("1 - Selecione 3 para Divisao.");
        Console.WriteLine("1 - Selecione 4 para Multiplicacao.");
        Console.WriteLine("\n");
        
        int opcao;

        opcao = int.Parse(Console.ReadLine());
        Random gerador = new Random();

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Voce escolheu adicao! segue:");
                Thread.Sleep(200);
                Console.Clear();

                int adicao1;
                int adicao2;

                Console.WriteLine("Digite o numero um:");
                adicao1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero dois:");
                adicao2 = int.Parse(Console.ReadLine());

                int numeroAleatorio1 = gerador.Next(-10, 11);

                int adresult;

                adresult = adicao1 + adicao2;
                int resultadoZoeira1 = numeroAleatorio1 + adresult;


                Console.WriteLine($"O resoltado que chegamos foi {resultadoZoeira1}");
                Console.WriteLine("\n");
                Console.WriteLine("Deseja ver o resultado real?");
                Console.WriteLine("Digite um para sim, e dois para nao.!");
                int duvida1 = int.Parse(Console.ReadLine());

                if (duvida1 == 1)
                {
                    Thread.Sleep(200);
                    Console.WriteLine($"O seu resutltado calculado real foi {adresult}");
                }
                else
                {
                    break;
                }

                break;

            case 2:
                Console.WriteLine("Voce escolheu subtracao! segue:");
                Thread.Sleep(200);
                Console.Clear();

                int subtracao1;
                int subtracao2;

                Console.WriteLine("Digite o numero um:");
                subtracao1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero dois:");
                subtracao2 = int.Parse(Console.ReadLine());

                int numeroAleatorio2 = gerador.Next(-10, 11);

                int subresult;

                subresult = subtracao1 - subtracao2;
                int resultadoZoeira2 = numeroAleatorio2 + subresult;


                Console.WriteLine($"O resoltado que chegamos foi {resultadoZoeira2}");
                Console.WriteLine("\n");
                Console.WriteLine("Deseja ver o resultado real?");
                Console.WriteLine("Digite um para sim, e dois para nao.!");
                int duvida2 = int.Parse(Console.ReadLine());

                if (duvida2 == 1)
                {
                    Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine($"O seu resutltado calculado real foi {subresult}");
                }
                else
                {
                    break;
                }

                break;

            case 3:
                Console.WriteLine("Voce escolheu divisao! segue:");
                Thread.Sleep(200);
                Console.Clear();

                int div1;
                int div2;

                Console.WriteLine("Digite o numero um:");
                div1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero dois:");
                div2 = int.Parse(Console.ReadLine());

                int numeroAleatorio3 = gerador.Next(-10, 11);

                int divresult;

                divresult = div1 / div2;
                int resultadoZoeira3 = numeroAleatorio3 + divresult;


                Console.WriteLine($"O resoltado que chegamos foi {resultadoZoeira3}");

                Console.WriteLine("\n");
                Console.WriteLine("Deseja ver o resultado real?");
                Console.WriteLine("Digite um para sim, e dois para nao.!");
                int duvida3 = int.Parse(Console.ReadLine());

                if (duvida3 == 1)
                {
                    Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine($"O seu resutltado calculado real foi {divresult}");
                }
                else
                {
                    break;
                }

                break;

            case 4:
                Console.WriteLine("Voce escolheu multiplicacao! segue:");
                Thread.Sleep(200);
                Console.Clear();

                int mult1;
                int mult2;

                Console.WriteLine("Digite o numero um:");
                mult1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o numero dois:");
                mult2 = int.Parse(Console.ReadLine());

                int numeroAleatorio4 = gerador.Next(-10, 11);

                int multresult;

                multresult = mult1 * mult2;
                int resultadoZoeira4 = numeroAleatorio4 + multresult;


                Console.WriteLine($"O resoltado que chegamos foi {resultadoZoeira4}");
                Console.WriteLine("\n");
                Console.WriteLine("Deseja ver o resultado real?");
                Console.WriteLine("Digite um para sim, e dois para nao.!");
                int duvida4 = int.Parse(Console.ReadLine());

                if (duvida4 == 1)
                {
                    Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine($"O seu resutltado calculado real foi {multresult}");
                }
                else
                {
                    break;
                }
                break;

            default:
                break;


        }
    }
}