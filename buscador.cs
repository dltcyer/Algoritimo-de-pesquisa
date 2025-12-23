class buscador
{
    public static Produto[] buscar(string valorA, Produto[] valorB)
    {
        Produto[] lista = new Produto[999];
        for (int i = 0; i < valorB.Length; i++)
        {
            if (valorB[i] == null || valorB[i].nome == null)
                continue;

            string valorNome = valorB[i].nome;
            string[] valorNome_semEspaco = valorNome.Split(" ");
            if (valorNome_semEspaco.Length > 1)
            {
                if (valorA == valorNome_semEspaco[0])
                {
                    lista[i] = valorB[i];
                }
            }
            else
            {
                if (valorNome == valorA)
                {
                    lista[i] = valorB[i];
                }
            }
        }
        return lista;
    }
}
