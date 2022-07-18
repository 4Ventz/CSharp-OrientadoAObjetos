//Você foi selecionado para ajudar a desenvolver um sistema console com o objetivo de realizar operações matemáticas. Ficou sob sua responsabilidade criar o modelo de classes para as operações básicas, como soma, multiplicação, subtração e divisão.

//Sabendo que o projeto vai evoluir, desafiamos você a criar e propor uma organização de classes em diretórios. Este é um exercício opcional, mas propomos praticar a escrita de códigos em C# um pouco mais e imaginar novas soluções para problemas. Então, aceita o desafio?
using Desafio_ClassesDeOperacoes.OpBasicas;
using Desafio_ClassesDeOperacoes;

Console.WriteLine("Bem vindo a Calculadora!");
Console.WriteLine();

Operacoes operacoes = new Operacoes();
Console.WriteLine("O valor é: " + operacoes.Soma.Calcular(10, 10));
Console.WriteLine("O valor é: " + operacoes.Subtracao.Calcular(10, 10));
Console.WriteLine("O valor é: " + operacoes.Divisao.Calcular(0, 10));
Console.WriteLine("O valor é: " + operacoes.Multi.Calcular(0, 10));

Console.ReadKey();