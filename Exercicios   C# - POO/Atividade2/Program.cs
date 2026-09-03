/*
- Atividade: Criar uma classe Aluno, contendo os atributos:
  a) nome
  b) nota1
  c) nota2

Haverá três métodos, sendo dois privados e um público:
Media: Método privado para retornar a média do aluno.
Situacao: Método privado para retornar se está aprovado ou reprovado.
Mensagem: Método publico para retornar o nome, média e situação.

- O que vamos utilizar: Classe, atributo, método, objeto e encapsulamento

*/

Aluno aluno1 = new();

aluno1.Nome = "Fabio emanuel";
aluno1.Nota1 = 8.35;
aluno1.Nota2 = 9.11;

aluno1.Mensagem();


Aluno aluno2 = new();

aluno2.Nome = "Joaquim Vinicius";
aluno2.Nota1 = 3.35;
aluno2.Nota2 = 7.11;


aluno2.Mensagem();
