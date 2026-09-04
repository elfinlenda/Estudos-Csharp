class Smartphone : Produto
{
    // atributo do Smart

    private string _sistema_operacional{get;set;}

    // construtor + heranca
    public Smartphone(string Nome1, string Marca1,double Valor1,string sistema )
    {
        Nome = Nome1;
        Marca = Marca1;
        Valor = Valor1;
        _sistema_operacional = sistema;

        ExibirInfo();
        Exibir2();
    }

    // metodo exibir
    private void Exibir2()
    {
        Console.WriteLine($"Sistema Operacional Smartphone:{_sistema_operacional}\n");
    }
}