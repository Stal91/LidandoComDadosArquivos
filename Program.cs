

CriarArquivo();


void CriarArquivo()
{
    using (var fluxoDeEntrada = Console.OpenStandardInput())
    using (var fs = new FileStream("arquivoSalvandoConsole.txt", FileMode.Create))
    {
        var buffer = new byte[1024];

        Console.WriteLine("Deseja Escrever dnv -1 SIM -2 NAO");
        string decisao = Console.ReadLine();

        if (decisao.Equals("1"))
        {
            while (true)
            {
                var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);

                fs.Write(buffer, 0, bytesLidos);
                fs.Flush();

                Console.WriteLine(bytesLidos);

                Console.WriteLine("Deseja Escrever dnv -1 SIM -2 NAO");
                decisao = Console.ReadLine();

                if (!decisao.Equals("1"))
                {
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Programa fechou");
        }
    }
}

