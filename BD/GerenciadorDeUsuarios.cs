using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BCrypt.Net; 
public class GerenciadorUsuarios
{
    public List<Usuario> ListaDeUsuarios { get; private set; }
    private readonly string _caminhoArquivo = "usuarios.json";

    public GerenciadorUsuarios()
    {
        ListaDeUsuarios = CarregarUsuarios();

        if (ListaDeUsuarios.Count == 0)
        {
            Console.WriteLine("Arquivo de dados nao encontrados. Criando usuario admin padrão...");

            string adminHash = BCrypt.Net.BCrypt.HashPassword("123");

            ListaDeUsuarios.Add(new Usuario("admin", adminHash, "ADM01", 3));
            SalvarUsuarios();
        
        }
    }

    private List<Usuario> CarregarUsuarios()
    {
        if (File.Exists(_caminhoArquivo))
        {
            try
            {
                string jsonString = File.ReadAllText(_caminhoArquivo);
                return JsonSerializer.Deserialize<List<Usuario>>(jsonString) ?? new List<Usuario>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar dados: {ex.Message}");
                return new List<Usuario>();
            }
        }
        return new List<Usuario>();
    }

    public void SalvarUsuarios()
    {
        var options = new JsonSerializerOptions {WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(ListaDeUsuarios, options);
        File.WriteAllText(_caminhoArquivo, jsonString);
    }

    public void CadastrarUsuario(Usuario novoUsuario)
    {
        if (ListaDeUsuarios.Exists(u => u.NomeUsuario == novoUsuario.NomeUsuario))
        {
            Console.WriteLine("Erro: Usuario com este nome ja existe.");
            return;
        }

        ListaDeUsuarios.Add(novoUsuario);
        SalvarUsuarios();
        Console.WriteLine($"Usuario {novoUsuario.NomeUsuario} cadastrado com sucesso");
    }

    public Usuario Autenticar(string nome, string senha)
    {
        Usuario usuarioEncontrado = ListaDeUsuarios.Find(u => u.NomeUsuario == nome);
                
        if(usuarioEncontrado != null)
        {
            if(BCrypt.Net.BCrypt.Verify(senha, usuarioEncontrado.SenhaHash))
            {
                return usuarioEncontrado; 
            }
        }
        
        return null; 
    }
}