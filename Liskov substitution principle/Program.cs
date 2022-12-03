
using Liskov_substitution_principle;

class Program
{
    static void Main()
    {
        // В переводе на русский звучит как Принцип подстановки Барбары Лисков.

        // Цель в том, чтобы подклассы могли бы служить заменой своих базовых классов.
        // При соблюдении этого принципа мы можем использовать классы-наследники вместо родительских классов, и работа программы не будет нарушена. 

        // Новый список полётов
        var flightsList = new List<Flight>()
        {
       new DomesticFlight("Mow-32", new List<string>() {"Вася", "Петя"}),
       new DomesticFlight("SPB-14", new List<string>() {"Андрей"})
        };

        // Считаем пассажиров
        FlightPassengerCount(flightsList);
    }
    /// <summary>
    /// Метод для подсчёта количества пассажиров
    /// </summary>
    public static void FlightPassengerCount(List<Flight> flights)
    {
        foreach (var flight in flights)
            flight.CountPassengers();
    }
}