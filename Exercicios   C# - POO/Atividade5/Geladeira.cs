class Geladeira : Produto
{
    // atributo da geladeira
    
    private double _capacidadeArmazenamento{get; set;}

    // construtor + heranca

    public Geladeira(string Nome1,string Marca1,double Valor1,double capacidade )
    {
        Nome = Nome1;
        Marca = Marca1;
        Valor = Valor1;
        _capacidadeArmazenamento = capacidade;

        ExibirInfo();
        Exibir1();
    }

    // metodo exibir 
    private void Exibir1()
    {
        Console.WriteLine($"Capacidade de Armazenamento Geladeira:{_capacidadeArmazenamento}\n");
    }

}