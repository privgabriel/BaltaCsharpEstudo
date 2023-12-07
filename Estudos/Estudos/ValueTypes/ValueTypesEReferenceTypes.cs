namespace Estudos.ValueTypes;

class ValueTypesEReferencesTypes
{
    static void Reference(string[] args)
    {
        int x = 25;
        int y = x; // y recebe o valor de x
        Console.WriteLine(x);
        Console.WriteLine(y);
        x = 32; // x recebe um novo valor
        Console.WriteLine(x);
        Console.WriteLine(y);
    }

    static void ComArray(string[] args)
    {
        var arr = new string[2];
        arr[0] = "Gabriel";
        var arr2 = arr; // Não cria uma cópia, apenas uma referência

        Console.WriteLine(arr[0]); // Gabriel
        Console.WriteLine(arr2[0]); // Gabriel
        
        arr[0] = "Nome Alterado";
        Console.WriteLine(arr[0]); // Nome Alterado
    }
}