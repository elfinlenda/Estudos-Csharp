class Colaborador : Pessoa
{
    // Atributos 
    private string _cargo;
    private float _salario;

    // construtor 

    public Colaborador(string nome,int idade, string cargo, float salario )
    {
        Nome = nome;
        Idade = idade;
        _cargo = cargo;
        _salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();
    }

    // metodo para apresentar os dados  
    private void ApresentarColaborador()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Salario: {_salario}");
    }

}