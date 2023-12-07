namespace Estudos.ValueTypes;

public class ValueTypes
{
    static void Main18(string[] args)
    {
        int x = 25; 
        int y = x; // y recebe o valor de x
        Console.WriteLine(x); // 25
        Console.WriteLine(y); // 25
        x = 32; // x recebe um novo valor
        Console.WriteLine(x); // 32
        Console.WriteLine(y); // 25
    }
}