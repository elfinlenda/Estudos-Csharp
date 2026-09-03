/*
    EXERCICIO 1

Atividade: Criar uma classe Produto, contendo os atributos:
a) nome
b) valor
c) forma de pagamento (à vista ou prazo)  

Haverá um método público para retornar essas três características, 
além de um possível desconto. Haverá desconto de 10% se o valor da
venda for de pelo menos R$500,00 e a forma de pagamento à vista.  

O que vamos utilizar: Classe, atributo, método, objeto e encapsulamento

*/


Console.WriteLine("----PROGRAMA TESTE---------\n");


Produto armario = new("Armario casas Bahia",7080,1);
Produto armario2 = new("Armario casas Bahia",501,1);

armario.AplicadorDeDesconto();
armario2.AplicadorDeDesconto();
