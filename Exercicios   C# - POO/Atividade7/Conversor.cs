class Conversor : Padrao
{
    // metodos de conversao
    public override void RealDolar(double recebido)
    {
        double dolar = 0.186 * recebido;
        Console.WriteLine($"Conversao de real para dolar e : ${dolar}");
    }

    public override void DolarReal(double recebido)
    {
        double real = 5.40 * recebido;
        Console.WriteLine($"Conversao de dolar para real e : R${real}");
    }
}