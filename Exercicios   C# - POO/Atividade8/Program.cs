/*
EXERCÍCIO 08

- Atividade: Crie as seguintes interfaces:
  IDesconto
  IBonus

Na interface IDesconto haverá apenas o método ValeTransporte.
Na interface IBonus haverá apenas o método PremioFaltas.

Crie uma classe Colaborador que implemente as duas interfaces.
O método ValeTransporte terá um parâmetro chamado salarioBruto, desconte 6%
sobre o salario informado.

O método PremioFaltas terá um parâmetro chamado faltas,
haverá um bônus de R$300,00 se não houver faltas.

- O que vamos utilizar: Classe, objeto, atributo, método e interface.
*/

Console.WriteLine("-----PROGRAMA COLABORADORES-----\n");

Colaborador Fabio = new();

Fabio.Faltas = 0;
Fabio.Salario = 25000;

Fabio.ValeTransporte();
Fabio.PremioFaltas();

Console.WriteLine("------------------------");

Colaborador bentoOvos = new();

bentoOvos.Faltas = 100;
bentoOvos.Salario = 50;

bentoOvos.ValeTransporte();
bentoOvos.PremioFaltas();