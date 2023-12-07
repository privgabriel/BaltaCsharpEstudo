namespace Estudos.NullabelTypes;

class Program
{
    static void Main9(string[] args)
    {
        int? idade = 0;
        Console.WriteLine(idade);
        idade = null;
        Console.WriteLine(idade);
        idade = 10;
        Console.WriteLine(idade);
    }
}