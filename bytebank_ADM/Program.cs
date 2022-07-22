using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas vindas ao Bytebank Administração.");
Console.WriteLine();

CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    
    Designer pedro = new Designer("123.456.789-01");
    pedro.Nome = "Pedro";

    Diretor paula = new Diretor("987.654.321-02");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("123.789.456-03");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("987.321.654-04");
    camila.Nome = "Camila";

    Desenvolvedor samya = new Desenvolvedor("123.654.789-05");
    samya.Nome = "Samya";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de Bonificação: R$ " + gerenciador.GetBonificacao());
}

Console.ReadKey();