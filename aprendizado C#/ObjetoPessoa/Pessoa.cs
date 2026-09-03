class Pessoa
{
    public string Nome;
    public int Idade;
    public string CPF;

    // metodo para apresentar alguem
    public void Apresentar()
    {
        Console.WriteLine($"Oi me chamo, {Nome}, e tenho {Idade} anos de idade !\n Com o CPF atal de: {CPF}");
    }

    // metodo para verificar a maioridade

    public void VerificaIdade()
    {
        if(Idade < 18)
        {
            Console.WriteLine("Medor de idade!");
        }
        else
        {
            Console.WriteLine("Maior de idade!");

        }
    }
}