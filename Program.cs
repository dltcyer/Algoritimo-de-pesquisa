class Program
{
    private static Dados _dadosService = new Dados();

    public static string inicio()
    {
        Console.Clear();
        Console.WriteLine("Olá, bem vindo ao buscador");
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1: Buscar item");
        Console.WriteLine("2: Adicionar Item");
        string valor = Console.ReadLine();
        pesquisa_inicio(valor);
        return valor;
    }

    public static string pesquisa_inicio(string valor)
    {
        switch (valor)
        {
            case "1":
                Dados serviceDados = new Dados();
                Produto[] produtos = serviceDados.IniciarValores();
                Console.WriteLine("Qual produto você está procurando: ");
                string valor_pesquisa = Console.ReadLine();
                int valores = 0;
                Console.Clear();
                Produto[] valorBusca = buscador.buscar(valor_pesquisa, produtos);

                for (int i = 0; i < valorBusca.Length; i++)
                {
                    if (valorBusca[i] == null) continue;

                    Console.WriteLine(valorBusca[i].nome);
                    valores++;
                }
                Console.WriteLine("Valores encontrados: " + valores);
                Console.WriteLine("limpar?");
                Console.WriteLine("s/n?");
                string valor2 = Console.ReadLine();
                switch (valor2)
                {
                    case "s": Console.Clear(); break;
                    case "n": return " ";
                }
                inicio();
                break;
            case "2":
                Produto[] produtos_case2 = _dadosService.IniciarValores();
                for (int i = 0; i < produtos_case2.Length; i++)
                {
                    if (produtos_case2[i] != null)
                    {
                        Console.WriteLine(produtos_case2[i].nome);
                    }
                }
                Console.WriteLine("Qual produto gostaria de adicionar");
                string resposta = Console.ReadLine();
                string precoString = Console.ReadLine();
                decimal preco = Convert.ToDecimal(precoString);
                bool adicionado = false;
                for (int i = 0; i < produtos_case2.Length; i++)
                {
                    if (produtos_case2[i] == null)
                    {
                        produtos_case2[i] = new Produto(i, resposta, preco);

                        Console.WriteLine($"Produto '{resposta}' adicionado!");
                        _dadosService.alterarValor(produtos_case2);
                        adicionado = true;
                        break;
                    }
                }

                if (!adicionado) Console.WriteLine("Não há espaço disponível.");


                Console.ReadKey();
                Console.Clear();
                inicio();
                break;
        }
        return " ";
    }

    static void Main(string[] args)
    {
        inicio();
    }
}