class Aluno
{
    // atributos do aluno
    // praticando manualmente get e set
    private string _nome;
    public string Nome
    {
        get{ return _nome;}
        set
        {
            _nome = value;
        }
    }

    private double _nota1;
    public double Nota1
    {
        get{ return _nota1;}
        set
        {   // logica p/ evitar a nota erraada
            if(value < 0 && value > 10)

                throw new ArgumentException(" valor de nota1 invalido!!");        
                _nota1 = value;
        }
    }

    private double _nota2;
    public double Nota2
    {
        get{ return _nota2;}
        set
        {   // logica p/ evitar a nota erraada
            if(value < 0 && value > 10)
            
                throw new ArgumentException(" valor de noda2 invalido!!");
                _nota2 = value;
        }
    }


// METODOS DE ALUNO
    private double Media()
    {
         return (Nota1 + Nota2)/2 ;
    }

    private string Situacao(double media)
    {
        if(media < 6 )
        {
           return "REPROVADO";
        }
        else
        {
            return "APROVADO";
        }
    }

    public void Mensagem()
    {
        double retorno = Media();
        string retorno2 = Situacao(retorno);
        Console.WriteLine($"INFORMACOES DO ALUNO\nNome:{Nome}\nMedia:{retorno}\nSituacao{retorno2}\n\n");
    }
}