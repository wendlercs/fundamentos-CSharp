namespace ExercicioRocketSeat1;

class Exerc2
{
    public static void NomeCompleto()
    {
        Console.WriteLine("Digite seu nome por favor");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome por favor");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}");
    }
}
