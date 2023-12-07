namespace Estudos.MetodosEFuncoes;

public class Main
{
    static void Main17(string[] args)
    {
        // Invocaçao do método
        MeuMetodo("Olá, mundo!");
        RetornaNome("Gabriel", "Santos");
    }
    
    // Declaraçao do método
    static void MeuMetodo(string parametro)
    {
        Console.WriteLine(parametro);
    }
    
    static string RetornaNome(string nome, string sobrenome)
    {
        return nome + " " + sobrenome;
    }
    
}
