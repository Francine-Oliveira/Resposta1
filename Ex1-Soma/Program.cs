namespace Ex1_Soma;
class Program
{
    static void Main(string[] args)
    {
        int indice = 13, soma = 0, K = 0;

        while (K < indice)
        {
            K++;
            soma += K;
        }

        Console.WriteLine(soma);

        Console.ReadKey();
    }
}

