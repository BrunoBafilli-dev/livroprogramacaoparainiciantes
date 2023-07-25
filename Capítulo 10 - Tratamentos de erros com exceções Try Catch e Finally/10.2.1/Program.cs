public class MeuErroPersonalizadoException : Exception
{
    public MeuErroPersonalizadoException()
    {
    }
    public MeuErroPersonalizadoException(string mensagem) : base(mensagem)
    {
    }
    public MeuErroPersonalizadoException(string mensagem, Exception innerException) : base(mensagem, innerException)
    {
    }
}
