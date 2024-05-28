namespace ExercicioRocketSeat1;

public class Exerc3
{
    public static void Matematica()
    {

        Console.WriteLine("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Soma dos números: {num1 + num2}");

        Console.WriteLine($"Subtração dos números: {num1 - num2}");

        Console.WriteLine($"Multiplicação dos números: {num1 * num2}");

        Console.WriteLine(num2 == 0d ? "Divisão indefinida pois o divisor é zero" : $"Divisão dos números: {num1 / num2}");

        Console.WriteLine($"Média dos números: {(num1 + num2) / 2}");
    }
}
