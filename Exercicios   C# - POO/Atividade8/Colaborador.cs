class Colaborador : IBonus, IDesconto
{

    // atributos dos colaboraadores com seus geters and seters 

    private double _salario;
    private int _faltas;

    public double Salario
    {
        get
        {
            return _salario;
        }

        set
        {
            _salario = value;
        }
    }

    public int Faltas
    {
        get
        {
            return _faltas;
        }

        set
        {
            _faltas = value;
        }
    }

    // metodos da questao

    public void PremioFaltas()
    {
        if(Faltas == 0)
        {
            Salario += 300;
            Console.WriteLine($"Parabens voce nao faltou nenhum dia, BONUS de 300 R$\n Salario:{Salario}");
        }
        else
        {
            Console.WriteLine($"houveram faltas portanto salario = {Salario}");
        }

    }

    public void ValeTransporte()
    {
        double salario_liquido = Salario * 0.94;
        Console.WriteLine($"Seu salario liquido apos os descontos e: {salario_liquido}");
    }

}