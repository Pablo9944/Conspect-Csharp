
using Игра;

class Program
{
    static void Main()
    {
        #region Описание создания игры
        // 1) Начнём с создания моделей для движений interface IMovement
        // 1.1) Создаем class RunMovement который реализует interface IMovement
        // 1.2) Создаем class FlyMovement который реализует interface IMovement

        // 2) Создадим модели оружия: 
        // 2.1) Создаем class Axe  который реализует interface IWeapon
        // 2.2) Создаем class FireBreath который реализует interface IWeapon

        // 3) Перейдем к созданию абстрактной фабрики: interface IMonsterFactory

        // 4) Создадим конкретные реализации фабрики: class DragonFactory class OrcFactory 
        // 4.1) class DragonFactory который реализует interface IMonsterFactory
        // 4.2) class OrcFactory который реализует interface IMonsterFactory

        // 5) Создадим class Monster, где будут использоваться фабрики: 

        // 6) Теперь применим реализации на практике!
        #endregion

        // Создание дракона через фабрику
        var dragon = new Monster(new DragonFactory());
        dragon.Move();
        dragon.Hit();

        Console.WriteLine();
        // Создание орка через фабрику
        var orc = new Monster(new OrcFactory());
        orc.Move();
        orc.Hit();

        Console.WriteLine();
        Console.WriteLine("Всем конец...");
    }
}