class Pessoa
{
    
    // Atributo 

    private string _nome;
    private int _idade;
    private string _cidade;

    // gets e sets manuais para maior adesao

    public string Nome
    {
        get {return _nome;}
        set
        {
            _nome = value;
        }
        
    }
    public int Idade
    {
        get {return _idade;}
        set
        {
            if(value < 0 || value > 200)
                throw new ArgumentException("VALOR INVALIDO P/ IDADE!!");

               _idade = value;
        }
        
    }
    public string Cidade
    {
        get {return _cidade;}
        set
        {
            _cidade = value;
        }
        
    }

    private void Mensagem()
    {
        Console.WriteLine("Ola aqui e o(a) :" + _nome + "\nSou da cidade:" + _cidade + "\nTenho idade de: " + _idade + "\n");
    }
    // CONSTRUTOR
    public Pessoa(string nome, int idade,string cidade)
    {
        _nome = nome;
        _idade = idade;
        _cidade = cidade;

        Mensagem();


    }


}