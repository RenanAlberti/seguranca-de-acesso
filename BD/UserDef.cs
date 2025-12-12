public class Usuario
{
    public string NomeUsuario { get; set; }
    public string SenhaHash { get; set; }
    public string CodigoAutenticacao { get; set; }
    public int NivelAcesso { get; set; }

    public Usuario(string nomeUsuario, string senhaHash, string codigoAutenticacao, int nivelAcesso)
    {
        NomeUsuario = nomeUsuario;
        SenhaHash = senhaHash;
        CodigoAutenticacao = codigoAutenticacao;
        NivelAcesso = nivelAcesso;
    }

    public override string ToString()
    {
        return $"Usuario: {NomeUsuario}, | Nivel: {NivelAcesso}, | Codigo: {CodigoAutenticacao}";
    }
}