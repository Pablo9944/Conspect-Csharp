
class Driver
{
    
    public void Drive(ICar car)
    {
        ICar car1 = car;
        car1.Drive();
    }
    static void Main ()
    {
        // Рекомендуется по возможности создавать узко-специализированные интерфейсы,
        // чтобы не тащить в классы излишний функционал, который вероятнее всего реализован не будет.

        // Тут стоит по возможности разделять интерфейс класса на отдельные части.
        // Позже вы сможете применять и изменять их независимо друг от друга. Следование этому принципу делает систему слабо связанной, её в итоге проще поддерживать и обновлять.

        // наш водитель
        var driver = new Driver();

        // водителю всё равно, на чём ехать

        Console.WriteLine("Садимся в седан");
        driver.Drive(new Sedane());

        Console.WriteLine();

        Console.WriteLine("Садимся в джип");
        driver.Drive(new Suv());
    }
    public interface ICar
    {
        void Drive();
    }
    public interface ICarPack
    {
        /// <summary>
        /// Ехать
        /// </summary>
        void Drive();

        /// <summary>
        /// Включить понижающую передачу
        /// </summary>
        void DriveDown();

        /// <summary>
        /// Заблокировать центральный дифференциал
        /// </summary>
        void LockDifferential();

        /// <summary>
        /// Включить систему помощи при спуске
        /// </summary>
        void DescentAssist();

        /// <summary>
        /// Включить круиз - контроль
        /// </summary>
        void CruiseControl();

        /// <summary>
        /// Включить полный привод
        /// </summary>
        void FourWheelDrive();
    }

    // Получается, у нас есть универсальный интерфейс ICarPack, который содержит весь мыслимый и немыслимый функционал, большая часть которого нам не нужна.
    
    // Сообразили, как мы можем переделать это в соответствии с Принципом разделения интерфейсов? 
    /// <summary>
    /// Интерфейс с общим функционалом
    /// </summary>
    public interface IGeneralPack
    {
        void Drive();
    }

    /// <summary>
    ///  Интерфейс подключения офф-роуд систем для внедорожников
    /// </summary>
    public interface IOffRoadPack
    {
        void DriveDown();
        void LockDifferential();
        void DescentAssist();
    }

    /// <summary>
    /// Интерфейс подключения систем повышенного комфорта
    /// </summary>
    public interface IPremiumPack
    {
        void CruiseControl();
    }

    /// <summary>
    /// Интерфейс подключения спортивных систем
    /// </summary>
    public interface ISportPack
    {
        void FourWheelDrive();
    }

    /// <summary>
    /// У нас премиум-седан, поэтому кроме обычных систем подключаем системы комфорта
    /// </summary>
    public class Sedane : ICar,IGeneralPack, IPremiumPack
    {
        public void Drive()
        {
            Console.WriteLine("Едем");
        }

        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }
    }
    /// <summary>
    ///  Премиум - внедорожник
    /// </summary>
    public class Suv :ICar,IPremiumPack, ISportPack, IOffRoadPack
    {
        public void Drive()
        {
            Console.WriteLine("Едем");
        }

        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }

        public void FourWheelDrive()
        {
            Console.WriteLine("Включаем полный привод");
        }

        public void DriveDown()
        {
            Console.WriteLine("Включаем систему помощи при спуске");
        }

        public void LockDifferential()
        {
            Console.WriteLine("Включаем блокировку центрального дифференциала");
        }

        public void DescentAssist()
        {
            Console.WriteLine("Включаем систему помощи при спуске");
        }
    }
}