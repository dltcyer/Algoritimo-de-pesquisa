class Produto
{
    public int ID { get; set; }
    public string nome { get; set; }
    public decimal preco { get; set; }

    public Produto(int IDproduto, string nomeproduto, decimal precoproduto)
    {
        ID = IDproduto;
        nome = nomeproduto;
        preco = precoproduto;
    }

}