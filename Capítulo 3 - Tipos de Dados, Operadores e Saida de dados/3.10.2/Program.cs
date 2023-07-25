Console.WriteLine("Pressione qualquer tecla...");
ConsoleKeyInfo teclaPressionada = Console.ReadKey();
Console.WriteLine("Tecla pressionada: " + teclaPressionada.Key);
Console.WriteLine("Caractere correspondente: " + teclaPressionada.KeyChar);
Console.WriteLine("Teclas de modificação: " + teclaPressionada.Modifiers);
