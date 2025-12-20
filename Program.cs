class Program
{
    static void Main(string[] args)
    {

        Dados.IniciarValores();

        string[] produtos = Dados.Produtos;

        Console.WriteLine("Olá, bem vindo ao buscador");
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1: Adicionar item");
        Console.WriteLine("2: Buscar Item");
        string valor = Console.ReadLine();

        switch (valor)
        {
            case "1":
                string valor_pesquisa = Console.ReadLine();
                Console.Clear();
                string[] valorBusca = buscador.buscar(valor_pesquisa, produtos);

                for (int i = 0; i < valorBusca.Length; i++)
                {
                    Console.WriteLine(valorBusca[i]);
                }
                break;
            case "2":
                break;
        }
    }
}