/*
EXERCÍCIO 07

- Atividade: Crie uma classe abstrata chamada Padrao contendo os métodos abstratos:
  RealDolar();
  DolarReal();

Crie uma nova classe chamada Conversor, essa classe irá herdar Padrao.
Nessa classe Conversor, implemente os dois métodos abstratos.

- O que vamos utilizar: Classe, objeto, atributo, método, herança e abstração.
*/

Conversor muitos_reais = new();

// fazendo de fato as conversoes

muitos_reais.DolarReal(500);

muitos_reais.RealDolar(500);