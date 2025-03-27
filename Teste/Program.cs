// See https://aka.ms/new-console-template for more information
using Funcionario;
using Teste.Models;

Console.WriteLine("Hello, World!");

Pessoa p1 = new Pessoa(nome: "Pedro", idade: 22);

p1.Apresentar();

UsuarioFuncionario p2 = new UsuarioFuncionario(nome: "Pedro", idade: 22);

p2.Longevidade();