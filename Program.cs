class Program
{
    public static string inicio()
    {

        Console.WriteLine("Olá, bem vindo ao buscador");
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1: Adicionar item");
        Console.WriteLine("2: Buscar Item");
        string valor = Console.ReadLine();
        pesquisa_inicio(valor);
        return valor;
    }
    public static string pesquisa_inicio(string valor)
    {
        Dados.IniciarValores();

        string[] produtos = Dados.Produtos;

        switch (valor)
        {
            case "1":
                Console.WriteLine("Qual produto você está preocurando: ");
                string valor_pesquisa = Console.ReadLine();
                int valores = 0;
                Console.Clear();
                string[] valorBusca = buscador.buscar(valor_pesquisa, produtos);

                for (int i = 0; i < valorBusca.Length; i++)
                {
                    if (valorBusca[i] == null)
                    {
                        continue;

                    }
                    Console.WriteLine(valorBusca[i]);
                    valores++;
                }
                Console.WriteLine("Valores encontrados: " + valores);
                Console.WriteLine("limpar?");
                Console.WriteLine("s/n?");
                string valor2 = Console.ReadLine();
                switch (valor2)
                {
                    case "s":
                        Console.Clear();
                        break;
                    case "n":
                        return " ";
                }
                inicio();
                break;
            case "2":
                break;
        }
        return " ";
    }
    static void Main(string[] args)
    {
        inicio();


    }
}