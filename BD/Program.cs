using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        GerenciadorUsuarios gerenciador = new GerenciadorUsuarios();

        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine(" === Bem vindo ao Sistema! ===");
            Console.WriteLine("1 - Cadastrar novo Usuario");
            Console.WriteLine("2 - Fazer Login.");
            Console.WriteLine("3 - Mostrar Usuarios Cadastrados (Apenas Debug).");
            Console.WriteLine("4 - Sair.");
            Console.WriteLine("\nDigite a opção desejada.");

            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int opcao))
            {
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        ServicosMenu.CadastrarNovoUsuario(gerenciador);
                        break;
                    case 2:
                        ServicosMenu.FazerLogin(gerenciador);
                        break;
                    case 3:
                        ServicosMenu.MostrarLista(gerenciador);
                        break;
                    case 4:
                        gerenciador.SalvarUsuarios();
                        continuar = false;
                        Console.WriteLine("Obrigado por usar o sistema! ");
                        break;

                    default:
                        Console.WriteLine("Opcao invalida. tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada invalida. Digite um numero.");
            }

            if(continuar)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}