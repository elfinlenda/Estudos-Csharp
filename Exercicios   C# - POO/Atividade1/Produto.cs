class Produto
{
    // atributos

    private string?  _nome;
    private double _valor;
    private int _formaDePagamento ;

    //Construtor
    public Produto(string nome, double valor, int formaDePagamento)
    {
        _nome = nome;
        _valor = valor;
        _formaDePagamento = formaDePagamento;
    }


    // get e set dos atributos 
    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            _nome = value;
        }
    }

    public double Valor
    {
        get {return _valor;}
        set
        {
            if(value < 0)

                throw new ArgumentException("Valor do pagamento invalido !! \n");
                _valor = value;
            
        }
    }

    public int Forma
    {
        get
        {
            return _formaDePagamento;
        }
        set
        {   if(value < 0 && value > 2)
        
            throw new ArgumentException("metodo de pagamento errado!! \n");
            _formaDePagamento = value;
        }

    }

    

    // unico metodo do exercicio

    public void AplicadorDeDesconto()
    {
        Console.WriteLine($"----DADOS DA COMPRA---- \nNome:{Nome}\nValor:{Valor}\nForma de Pagamento: {Forma}");

        int opcao = Forma;
        // opcao 1 sera: A VISTA e a opcao 2: PARCELADO
         switch(opcao)
        {
            case 1:
                    if(Valor >= 500)
                    {
                        Valor = Valor - (Valor * 0.1);
                        Console.WriteLine($"Voce obteve um desconto de 10% e o valor foi para: {Valor}");
                    }else
                    {
                        Console.WriteLine($"Valor nao obteve desconto pois e menos de 500! \n Valor: {Valor}");
                    }
                    
                    
                        
                        
            break;
            
            case 2:

                Console.WriteLine($"A compra foi parcelada nao tem desconto!! \nValor: {Valor}");
                    
            break;

            default:

                Console.WriteLine("Opcao de pagamento invalida");
            
            break;
        }
    }

}