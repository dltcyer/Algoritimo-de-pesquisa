class buscador
{
    public static string[] buscar(string valorA, string[] valorB)
    {
        string[] lista = new string[999999];

        for (int i = 0; i < valorB.Length; i++)
        {
            if (valorB[i] == null)
            {
                continue;
            }
            string valor = valorB[i];
            string[] valorSespaco = valor.Split(' ');

            for (int j = 0; j < valorSespaco.Length; j++)
            {
                if (valorSespaco[j] == valorA && !lista.Contains(valorB[i]))
                {
                    lista[i] = valorB[i];
                }
            }

        }
        return lista;
    }
}
