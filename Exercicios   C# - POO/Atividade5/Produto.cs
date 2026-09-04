class Produto
{
    // atributos 

    protected string Nome{get; set;}
    protected string Marca{get; set;}
    protected double Valor{get; set;}

    protected void ExibirInfo()
    {
        Console.WriteLine($"Nome do Produto:{Nome} \nMarca do Produto:{Marca}\nValor do Produto{Valor}");
    }

}