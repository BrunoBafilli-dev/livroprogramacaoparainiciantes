void ExecutarOperacao(Action callback)
{
    // Simulação de uma operação assíncrona
    Thread.Sleep(2000); // Aguarda 2 segundos para execução a função abaixo
    callback();
}

void FuncaoDeCallback()
{
    Console.WriteLine("Operação concluída!");
}
ExecutarOperacao(FuncaoDeCallback);
