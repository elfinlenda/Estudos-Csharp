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


Console.WriteLine("----PROGRAMA TESTE----\n");


Produto armario = new();
armario.Nome = "Armario";
armario.Valor = 5000 ;
armario.Forma = 1;

armario.AplicadorDeDesconto();


Produto balde = new();
balde.Nome = "Balde verde";
balde.Valor = 9999 ;
balde.Forma = 1;

balde.AplicadorDeDesconto();
// armario2.AplicadorDeDesconto();
