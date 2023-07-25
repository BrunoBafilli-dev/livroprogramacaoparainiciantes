/*
2 - Crie uma exceção personalizada chamada NomeInvalidoException que será lançada quando 
um usuário digitar um nome vazio ou nulo.
*/

/**************************Solução abaixo*********************************/

Console.WriteLine("Digite um nome:");
string nome = Console.ReadLine();

try
{
    // Verifica se o nome é vazio ou nulo
    if (string.IsNullOrEmpty(nome))
    {
        // Lança a exceção personalizada com a mensagem apropriada
        throw new NomeInvalidoException("Nome inválido!");
    }

    // Se o nome for válido, continua com o restante do código
    Console.WriteLine("Nome válido: " + nome);
}
catch (NomeInvalidoException ex)
{
    // Captura a exceção personalizada e exibe a mensagem de erro
    Console.WriteLine("Erro: " + ex.Message);
}

// Definição da classe de exceção personalizada
public class NomeInvalidoException : Exception
{
    public NomeInvalidoException(string message) : base(message)
    {
    }
}