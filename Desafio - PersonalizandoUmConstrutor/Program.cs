//Sabemos como utilizar o construtor para definir uma restrição para criação de um objeto. Usamos o construtor no projeto do byteBank_ADM durante a criação de funcionários e foi necessário informar o CPF de cada um.

//Agora imagine ter que modelar uma classe de livros com título, autor, ISBN, ano de publicação, estilo literário, número de páginas e país de publicação. Como podemos tornar o ISBN e o título informações obrigatórias, ou seja, que a pessoa que cria os objetos da classe precisa passar?

//Sua missão, é criar este construtor personalizado para a classe Livro. Este é um exercício opcional, mas propomos praticar a escrita de códigos em C# um pouco mais e imaginar novas soluções para problemas. Então, aceita o desafio?
using Desafio___PersonalizandoUmConstrutor;
using Desafio___PersonalizandoUmConstrutor.Produtos;

Console.WriteLine("Bem vindo ao cadastro de Produtos!");
Console.WriteLine();

Livros livro1 = new Livros("123.456.789", "Teste 1");

livro1.ExibirDadosProduto();

Livros livro2 = new Livros("978-85-7608-267-5", "Código Limpo: Habilidade e Páticas do Agile Software");
livro2.Autor = "Robert C. Martin";
livro2.AnoPublicacao = 2019;
livro2.EstiloLiterario = "Tecnologia";
livro2.NumeroPaginas = 456;
livro2.PaisPublicacao = "Estados Unidos";

livro2.ExibirDadosProduto();

Console.ReadKey();