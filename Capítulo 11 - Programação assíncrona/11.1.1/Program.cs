using System.IO;
string nomeArquivo = "exemplo.txt";
string conteudo = "Conteúdo do arquivo.";

try
{
    using (StreamWriter writer = new StreamWriter(nomeArquivo))
    {
        writer.WriteLine(conteudo);
    }
    Console.WriteLine("Arquivo criado com sucesso!");
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro ao criar o arquivo: " + ex.Message);
}
