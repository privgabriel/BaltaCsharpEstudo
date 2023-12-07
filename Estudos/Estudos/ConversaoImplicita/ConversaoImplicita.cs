namespace Estudos.ConversaoImplicita;

public class ConversaoImplicita
{
    static void Main12(string[] args)
    {
        float valor = 25.8F;
        int outro = 25;

        valor = outro; // Conversão implícita de int para float
    }
}