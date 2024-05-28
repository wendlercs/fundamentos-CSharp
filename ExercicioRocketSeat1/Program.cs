using FundamentosCSharp;

namespace ExercicioRocketSeat1;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o exercicio de 1 a 5");
        Console.WriteLine("1 - Mensagem Bem-vindo");
        Console.WriteLine("2 - Nome Completo");
        Console.WriteLine("3 - Matematica");
        Console.WriteLine("4 - Contador caracteres");
        Console.WriteLine("5 - Valida Placa-Veiculo");
        Console.WriteLine("6 - Formato da data atual");

        string idExercicio = Console.ReadLine();

        switch (idExercicio)
        {
            case "1":
                Exerc1.BemVindo();
                break;
            case "2":
                Exerc2.NomeCompleto();
                break;
            case "3":
                Exerc3.Matematica();
                break;
            case "4":
                Exerc4.ContadorCaracter();
                break;
            case "5":
                Exerc5.PlacaVeiculo();
                break;
            case "6":
                Exerc6.FormatoDataHoje();
                break;
        }   
    }
}
