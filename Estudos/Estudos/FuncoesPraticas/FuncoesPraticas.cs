namespace Estudos.FuncoesPraticas;

public class FuncoesPraticas
{
    static void Main18(string[] args)
    {
        MeuMetodo();
        string nome = RetornaNome("Gabriel", "Santos", 22);
        Console.WriteLine(nome);
    }
    static void MeuMetodo()
    {
        Console.WriteLine("C# é legal!");
    }

    static string RetornaNome(string nome, string sobrenome, int idade)
    {
        return nome + " " + sobrenome + " Tem " + idade + " anos.";
    }
    
}