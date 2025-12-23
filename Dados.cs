class Dados
{
    private static Produto[] _produtos = new Produto[150];
    private static bool _inicializado = false;

    public Produto[] IniciarValores()
    {
        if (!_inicializado)
        {
            _produtos[0] = new Produto(1, "teclado", 99.90m);
            _produtos[1] = new Produto(2, "teclado mecânico", 299.90m);
            _produtos[2] = new Produto(3, "mouse gamer", 149.90m);
            _produtos[3] = new Produto(4, "monitor gamer", 1299.00m);

            _inicializado = true;
        }

        return _produtos;
    }

    public Produto[] alterarValor(Produto[] dados)
    {
        _produtos = dados;
        return _produtos;
    }

    public Produto[] GetProdutos()
    {
        return _produtos;
    }
}