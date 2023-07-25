using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task CriarArquivoAsync(string nomeArquivo, string conteudo)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                await writer.WriteAsync(conteudo);
            }

            Console.WriteLine($"Arquivo '{nomeArquivo}' criado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro ao criar o arquivo '{nomeArquivo}': {ex.Message}");
        }
    }
    static async Task Main()
    {
        string nomeArquivo1 = "arquivo1.txt";
        string nomeArquivo2 = "arquivo2.txt";
        string conteudo = "Este é o conteúdo do arquivo.";
        Console.WriteLine("Início do programa.");
        Task task1 = CriarArquivoAsync(nomeArquivo1, conteudo);
        Task task2 = CriarArquivoAsync(nomeArquivo2, conteudo);
        await Task.WhenAll(task1, task2);
        Console.WriteLine("Fim do programa.");
    }
}
