namespace FundamentosCSharp;

class Exerc1
{
    public static void BemVindo()
    {
        Console.WriteLine("Digite seu nome para a mensagem de boas vindas!");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}! Seja muito bem-vindo!");
    }
}

