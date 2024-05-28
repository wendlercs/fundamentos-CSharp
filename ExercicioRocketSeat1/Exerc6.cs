using System.Globalization;

namespace ExercicioRocketSeat1;

public class Exerc6
{
    public static void FormatoDataHoje()
    {
        Console.WriteLine("Qual o formato desejado da data atual? (Digite o numero)");
        Console.WriteLine("1 - Formato Completo");
        Console.WriteLine("2 - Apenas data (padrão brasileiro)");
        Console.WriteLine("3 - Apenas o horario no formato 24 horas");
        Console.WriteLine("4 - Data com o mês por extenso");
        Console.WriteLine("5 - Para cancelar a execução");

        DateTime dateTime = DateTime.Now;

        while (true)
        {
            string idFormato = Console.ReadLine();

            if (idFormato == "5")
                break;

            switch (idFormato)
            {
                case "1":
                    Console.WriteLine($"{dateTime.DayOfWeek}, {dateTime.ToString("dd-MM-yyyy HH:mm:ss")}");
                    break;
                case "2":
                    Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
                    break;
                case "3":
                    string formatDateTime = dateTime.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
                    Console.WriteLine(formatDateTime);
                    break;
                case "4":
                    Console.WriteLine(dateTime.ToString("dd/MMMM/yyyy"));
                    break;
            }
        }
    }
}
