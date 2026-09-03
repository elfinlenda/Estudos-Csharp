namespace MeuProjeto;

class Program
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); //a esse comando ja quebra a linha automaticamente sem necessidade de colocar o \n no final da frase

            Console.Write("\nbom dia, Fabio ! Aprendendo C# do comeco \n"); // aqui esta comum como em C/C++

            // tipos de variaveis !
            // int -> variavel do tipo inteiro
            // float -> variavel do tipo decimal
            // decimal -> variavel do tipo decimal com maior precisao
            // double -> variavel do tipo decimal com maior precisao
            // var -> variavel do tipo indefinido, o compilador vai definir o tipo da variavel de acordo com o valor atribuido a ela
            // bool -> variavel do tipo booleano, que pode ser verdadeiro ou falso
            // string -> variavel do tipo texto, que pode conter letras, numeros e caracteres especiais
            // char -> variavel do tipo caractere, que pode conter apenas um caractere
            // dynamic -> variavel do tipo indefinido, que pode mudar de tipo durante a execucao do programa -> situacoes muito especificas, nao e muito usado
            
            dynamic variavelgay = "lula e bolsonaro"; 

            Console.WriteLine(variavelgay); 


            variavelgay = 112.34;

            Console.WriteLine(variavelgay);

            // como descobrir o tipo de uma variavel em C# ?
            // usando o metodo GetType() da classe Object, que retorna o tipo da variavel

            Console.WriteLine(variavelgay.GetType());



            // agora vou fazer testes de entrada de dados pelo teclado
            // isso faz sentido ?
            Console.Write("Digite seu AQUI sua altura: "); // exibindo frase para pegar altura

            int altura;

            while (!int.TryParse(Console.ReadLine(), out  altura) || altura < 0 ) // caso a entrada seja diferente de um numero inteiro, o programa vai pedir para digitar novamente a altura
            {
                Console.WriteLine("Valor invalido, digite novamente sua altura: ");
            }



            Console.Write("Inser now your age first and weight after:");
            int age;
            float weight;

            while (!int.TryParse(Console.ReadLine(),out age)|| age <= 0 )
            {
                Console.Write("preenchimento incorreto da idade, \n digite novamente :");
            }

            while (!float.TryParse(Console.ReadLine(),out weight) || weight <= 0)
            {
                Console.Write("Voce digitou um peso invalido! \n tente de novo: ");
            }


            Console.Write("Your age is:");
            Console.WriteLine(age);
            Console.Write("Your weight is:");
            Console.WriteLine(weight);
            Console.Write("Your height is: ");
            Console.WriteLine(altura);
            
            Console.Write("Escreva portanto o seu nome aqui :");
            string Nome_usuario = Console.ReadLine();

            Console.WriteLine("seu nome portanto e " + Nome_usuario);
    

        }
    }
}
