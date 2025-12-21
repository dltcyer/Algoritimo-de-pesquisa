class Dados
{
    private static string[] _produtos = new string[150];
    private static bool _inicializado = false;

    public string[] IniciarValores()
    {
        if (!_inicializado)
        {
            _produtos[0] = "teclado";
            _produtos[1] = "teclado mecânico";
            _produtos[2] = "teclado gamer";
            _produtos[3] = "teclado sem fio";

            _produtos[4] = "mouse";
            _produtos[5] = "mouse gamer";
            _produtos[6] = "mouse sem fio";
            _produtos[7] = "mouse óptico";

            _produtos[8] = "monitor";
            _produtos[9] = "monitor gamer";
            _produtos[10] = "monitor full hd";
            _produtos[11] = "monitor 4k";

            _produtos[12] = "headset";
            _produtos[13] = "headset gamer";
            _produtos[14] = "fone de ouvido";
            _produtos[15] = "fone bluetooth";

            _produtos[16] = "notebook";
            _produtos[17] = "notebook gamer";
            _produtos[18] = "notebook ultrafino";
            _produtos[19] = "notebook empresarial";

            _produtos[20] = "computador";
            _produtos[21] = "computador gamer";
            _produtos[22] = "computador desktop";
            _produtos[23] = "computador compacto";

            _produtos[24] = "impressora";
            _produtos[25] = "impressora laser";
            _produtos[26] = "impressora jato de tinta";

            _produtos[27] = "scanner";

            _produtos[28] = "pen drive";
            _produtos[29] = "pen drive 32gb";
            _produtos[30] = "pen drive 64gb";

            _produtos[31] = "hd externo";
            _produtos[32] = "ssd";
            _produtos[33] = "ssd nvme";

            _produtos[34] = "cabo hdmi";
            _produtos[35] = "cabo usb";
            _produtos[36] = "cabo usb c";

            _produtos[37] = "roteador";
            _produtos[38] = "roteador wifi 6";

            _produtos[39] = "switch de rede";

            _produtos[40] = "placa de video";
            _produtos[41] = "placa de video gamer";

            _produtos[42] = "placa mae";

            _produtos[43] = "processador";
            _produtos[44] = "processador intel";
            _produtos[45] = "processador amd";

            _produtos[46] = "memoria ram";
            _produtos[47] = "memoria ram 8gb";
            _produtos[48] = "memoria ram 16gb";

            _produtos[49] = "cooler";
            _produtos[50] = "cooler rgb";

            _produtos[51] = "gabinete";
            _produtos[52] = "gabinete gamer";

            _produtos[53] = "cadeira gamer";
            _produtos[54] = "mesa para computador";

            _produtos[55] = "webcam";
            _produtos[56] = "microfone";

            _produtos[57] = "caixa de som";
            _produtos[58] = "soundbar";

            _produtos[59] = "tablet";

            _produtos[60] = "smartphone";
            _produtos[61] = "smartphone android";
            _produtos[62] = "smartphone ios";

            _produtos[63] = "carregador";
            _produtos[64] = "carregador rapido";

            _produtos[65] = "power bank";

            _produtos[66] = "smartwatch";

            _produtos[67] = "controle de videogame";
            _produtos[68] = "console";
            _produtos[69] = "jogo digital";
            _produtos[70] = "jogo fisico";

            _produtos[71] = "adaptador bluetooth";
            _produtos[72] = "adaptador wifi";

            _produtos[73] = "camera de seguranca";

            _produtos[74] = "lampada inteligente";
            _produtos[75] = "tomada inteligente";

            _produtos[76] = "ventilador";
            _produtos[77] = "ar condicionado";

            _produtos[78] = "cafeteira";
            _produtos[79] = "liquidificador";

            _produtos[80] = "micro ondas";
            _produtos[81] = "forno eletrico";

            _produtos[82] = "air fryer";
            _produtos[83] = "chaleira eletrica";

            _produtos[84] = "filtro de agua";

            _produtos[85] = "garrafa termica";

            _produtos[86] = "mochila";
            _produtos[87] = "bolsa";

            _produtos[88] = "capa de notebook";
            _produtos[89] = "capa de celular";

            _produtos[90] = "pelicula de vidro";

            _produtos[91] = "tripe";

            _produtos[92] = "drone";

            _produtos[93] = "cartao de memoria";
            _produtos[94] = "leitor de cartao";

            _produtos[95] = "kit de ferramentas";

            _produtos[96] = "antena";

            _produtos[97] = "estabilizador";

            _produtos[98] = "nobreak";

            _produtos[99] = "roteador mesh";
        }

        return _produtos;
    }

    public string[] alterarValor(string[] dados)
    {
        _produtos = dados;
        return _produtos;
    }

    public string[] GetProdutos()
    {
        return _produtos;
    }
}