namespace ExercicioRocketSeat1;

public class Exerc5
{
    public static void PlacaVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo");
        string placa = Console.ReadLine().Replace("-", "");

        if(placa.Length != 7)
        {
            Console.WriteLine("Formato de placa incorreto");
            return;
        }

        var validaPlaca = ValidaPlaca(placa);

        Console.WriteLine(validaPlaca);
    }

    public static bool ValidaPlaca (string placa)
    {
        var arrPlaca = placa.ToArray();

        for(int i = 0; i < 3; i++)
        {
            if (!Char.IsLetter(arrPlaca[i]))
                return false;
        }

        for (int i = 3; i < 7; i++)
        {
            if (!Char.IsDigit(arrPlaca[i]))
                return false;
        }

        return true;
    }
}
