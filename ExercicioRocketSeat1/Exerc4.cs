namespace ExercicioRocketSeat1;

public class Exerc4
{
    public static void ContadorCaracter()
    {
        string[] palavras = new string[3];
        Console.Write("Digite 3 palavras para ser feito o contador de caracter");

        for (int i = 0; i < palavras.Length; i++)
        {
            Console.WriteLine($"Digite a {i + 1} palavra:");
            palavras[i] = Console.ReadLine();
        }

        var concatPalavras = string.Concat(palavras);

        int caracteres = concatPalavras.Length;

        Console.WriteLine($"Número de caracteres = {caracteres}");
    }
}
