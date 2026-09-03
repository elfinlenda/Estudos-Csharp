class Pessoa
{

        // primeiro construtor

    public Pessoa()
    {
        Console.WriteLine("Opa eae, tudo bem ?");
    }

    // segundo construtor 
    public Pessoa(string nome)
    {
        Console.WriteLine($"O nome dessa pessoa e {nome}");
    }

    // terceiro construtor
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"seu nome :{nome} e sua idade e {idade}");
    }
}