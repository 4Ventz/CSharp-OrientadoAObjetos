using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Console.WriteLine("Boas vindas ao Bytebank Administração.");
Console.WriteLine();

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
GerenciadorDePremioSemestral gerenciadorP = new GerenciadorDePremioSemestral();

Funcionario joao = new Funcionario();
joao.Nome = "João";
joao.Cpf = "123456789";
joao.Salario = 2000;

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "987654321";
paula.Salario = 5000;

Funcionario andre = new Diretor(); // Isso é possível pois a classe Diretor recebe herança da classe Funcionário

Console.WriteLine("Bonificação João: " + joao.GetBonificacao());
Console.WriteLine("Bonificação Paula: " + paula.GetBonificacao());
Console.WriteLine();
Console.WriteLine("Prêmio Semestral João: " + joao.GetPremioSemestral());
Console.WriteLine("Prêmio Semestral Paula: " + paula.GetPremioSemestral());
Console.WriteLine();

gerenciador.Registrar(joao);
gerenciadorP.Registrar(joao);
gerenciador.Registrar(paula);
gerenciadorP.Registrar(paula);


Console.WriteLine("Total de Bonificação: " + gerenciador.GetBonificacao());
Console.WriteLine("Premiação Total: " + gerenciadorP.GetPremiacao());

Console.ReadKey();