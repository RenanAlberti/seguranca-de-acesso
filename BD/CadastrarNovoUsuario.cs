using System;
using System.Collections.Generic;
using System.Threading;
using BCrypt.Net;

public static class ServicosMenu{

public static void CadastrarNovoUsuario(GerenciadorUsuarios gerenciador)
{
    Console.WriteLine("Digite o Nome de Usuario.");
    string user = Console.ReadLine()!;

    Console.WriteLine("Digite a senha:");
    string pwd = Console.ReadLine()!;

    Console.WriteLine("Digite o codigo de autenticação:");
    string codigo = Console.ReadLine()!; 

    int nivel = 0;
    bool nivelValido = false;
    while (!nivelValido)
    {
        Console.WriteLine("Digite o nivel de acesso (de 1 a 3).");
                if (int.TryParse(Console.ReadLine()!, out nivel) && nivel >= 1 && nivel <= 3) 
        {
            nivelValido = true;
        }

        else
        {
            Console.WriteLine("Nivel invalido, digite 1, 2 ou 3.");
        }

    }

    string SenhaHash = BCrypt.Net.BCrypt.HashPassword(pwd);

   
    Usuario novo = new Usuario(user, SenhaHash, codigo, nivel); 
    gerenciador.CadastrarUsuario(novo);

}


public static void FazerLogin(GerenciadorUsuarios gerenciador) {
    Console.Clear();
    Console.WriteLine(" == FAZER LOGIN ===");
    Console.WriteLine("\n");
    Console.WriteLine("Digite o seu usuario.");
    string user = Console.ReadLine()!; 
    Console.WriteLine("Digite a sua senha:");
    string pwd = Console.ReadLine()!; 
    Console.WriteLine("\nAguardando..");
    Thread.Sleep(500);

    Usuario usuarioLogado = gerenciador.Autenticar(user, pwd);

    if (usuarioLogado != null)
    {
        Console.WriteLine($"\n BEM VINDO, {usuarioLogado.NomeUsuario}!");
        Console.WriteLine($"Seu nivel de acesso é: {usuarioLogado.NivelAcesso}");
    }
    else
    {
        Console.WriteLine("\n Falha na autenticação. Usuario ou senha incorreta.");
    }
}

    public static void MostrarLista(GerenciadorUsuarios gerenciador) {
        Console.Clear();
        Console.WriteLine(" == USUARIOS CADASTRADOS ===");

        if (gerenciador.ListaDeUsuarios.Count == 0)
        {
            Console.WriteLine("Nenhum usuario cadastrado");
        }
        else
        {
            foreach (var u in gerenciador.ListaDeUsuarios)
            {
                Console.WriteLine($"- {u.ToString()}");
            }
        }
    }

}