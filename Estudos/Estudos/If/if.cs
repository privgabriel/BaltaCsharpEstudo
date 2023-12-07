namespace Estudos.If;

public class ifAula {

    static void Main15(string[] args)
    {
        int idade = 18;
        int maiorIdade = 21;
        int idadeMaxima = 65;
        
        if (idade >= maiorIdade && idade < idadeMaxima)
        {
            Console.WriteLine("Você pode entrar na festa!");
        }
        else
        {
            Console.WriteLine("Você não pode entrar na festa!");
        }
    }
}