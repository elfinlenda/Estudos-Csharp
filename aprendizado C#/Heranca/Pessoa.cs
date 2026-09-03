class Pessoa
{
    // atributos
    protected string Nome;
    protected int Idade;

    // metodo 
    protected void ApresentarPessoa()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
    }

}