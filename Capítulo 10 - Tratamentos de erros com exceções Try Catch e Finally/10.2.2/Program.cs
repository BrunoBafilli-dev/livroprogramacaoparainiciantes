try
{
    // Algum código que pode gerar sua exceção personalizada
    throw new MeuErroPersonalizadoException("Ocorreu um erro personalizado.");
}
catch (MeuErroPersonalizadoException ex)
{
    Console.WriteLine("Exceção personalizada capturada: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Exceção genérica capturada: " + ex.Message);
}
finally
{
    Console.WriteLine("Finalizando o bloco try-catch-finally.");
}
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
