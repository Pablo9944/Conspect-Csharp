
using Open_closed_principle;

class Program
{
    static void Main()
    {
        // Сущности программы должны быть открыты для расширения, но закрыты для модификации.


        //Иначе говоря, вы должны проектировать классы так,
        //чтобы при необходимости их можно было легко дополнить (то есть оставлять задел на будущее, возможности для масштабирования и роста функционала).

        BoardComputer bc = new BoardComputer();
        bc.PerformLanding(new GroundLandingProfile());
        Console.WriteLine();
        bc.PerformLanding(new WaterLandingProfile());
    }
}