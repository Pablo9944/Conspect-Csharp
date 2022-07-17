
class Program
{
    static void Main()
    {
        #region Виды
        // SINGLETON - одиночка
        // ABSTRACT FACTORY - абстрактная фабрика
        // FACTORY METHOD - фабричный метод
        #endregion

        #region Пример реализации Singleton

        //// создаем объект приложения
        //Application app = new Application();

        //// запускаем наше приложение (внутри создается соединение с базой данных по переданному адресу)
        //app.Launch("10.30.60.80");
        //Console.WriteLine(app.DbConnection.Configuration);

        //// Теперь пробуем создать новое соединение с базой данных уже по другому адресу
        //app.DbConnection = DbConnection.GetConnectionInstance("10.30.60.81");
        //// у нас не получилось, так как объект уже существует
        //Console.WriteLine(app.DbConnection.Configuration);

        //// Таким образом, все реализации паттерна Singleton сводятся к тому, чтобы скрыть метод-конструктор по умолчанию и создать публичный статический метод,
        //// который и будет контролировать жизненный цикл единственного нужного нам объекта при вызове из любой точки кода вашего приложения.
        #endregion

        #region Abstract Factory
        // Паттерн Abstract Factory позволяет нам создавать группы связанных объектов без привязки к конкретным классам.

        // Применять стоит в следующих случаях: 
        // 1) Ваша система не должна зависеть от способа компоновки объектов.
        // 2) Объекты в вашей системе должны использоваться вместе и быть взаимосвязанными.

        Client client = new Client(new ConcreteFactory1());

        #endregion

        #region Factory Method
        // Порождающий паттерн Factory Method даёт нам возможность определить некую универсальную конструкцию для создания объектов
        // в основном классе. Далее в классах-наследниках будет приниматься решение о том, какой именно тип объекта будет создан.

        // Таким образом, предполагается, что основной класс делегирует создание объектов классам-наследникам.
        // Этот паттерн стоит применять в следующих случаях:
        // 1) Когда заранее неизвестен тип создаваемых объектов.
        // 2) Когда в системе нужно заранее предусмотреть независимость от процесса создания новых объектов и расширяемость.
        // При этом легко можно будет добавлять поддержку создания объектов нового класса.
        // 3)  Когда создание объектов необходимо делегировать от основного класса классам - наследникам.

        #endregion

        
    }
}

#region Singleton пример реализации

//Пример, где можно было бы реализовать Синглтон — соединение программы с базой данных.

class DbConnection
{
    private static DbConnection Connection;

    public string Configuration { get; private set; }

    protected DbConnection(string configuration)
    {
        Configuration = configuration;
    }
    /// <summary>
    /// Реализация Синглтона не позволяет нам плодить новые объекты, если объект уже существует
    /// </summary>
    public static DbConnection GetConnectionInstance(string dbServer)
    {
        if (Connection == null)
            Connection = new DbConnection(dbServer);
        return Connection;
    }
}

//Простой пример

//class Singleton
//{
//    // Статическая переменная - ссылка на конкретный экземпляр объекта
//    private static Singleton Instance;

//    // Приватный конструктор
//    private Singleton()
//    { }

//    // Конструктор вызывается для создания объекта, если он отсутствует 
//    public static Singleton GetInstance()
//    {
//        if (Instance == null)
//            Instance = new Singleton();

//        return Instance;
//    }
//}
class Application
{
    public DbConnection DbConnection { get; set; }
    public void Launch(string dbServer)
    {
        DbConnection = DbConnection.GetConnectionInstance(dbServer);
    }
}
#endregion

#region Abstract Factory пример реализации

abstract class AbstractProductA
{ }

abstract class AbstractProductB
{ }

class ProductA1 : AbstractProductA
{ }

class ProductB1 : AbstractProductB
{ }

class ProductA2 : AbstractProductA
{ }

class ProductB2 : AbstractProductB
{ }
interface IAbstractFactory
{
    // Абстрактный метод для создания продукта  A
    AbstractProductA CreateProductA();

    // Абстрактный метод для создания продукта  B
    AbstractProductB CreateProductB();
}
class ConcreteFactory1 : IAbstractFactory
{
    // Конкретная реализация метода для создания продукта  A
    public AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    // Конкретная реализация метода для создания продукта  A
    public AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}
class ConcreteFactory2 : IAbstractFactory
{
    // Конкретная реализация метода для создания продукта  A
    public AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    // Конкретная реализация метода для создания продукта  B
    public AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}
class Client
{
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;

    /// <summary>
    ///  Конструктор класса, в котором происходит создание объектов фабрики
    /// </summary>
    public Client(IAbstractFactory factory)
    {
        _abstractProductB = factory.CreateProductB();
        _abstractProductA = factory.CreateProductA();
    }

    /// <summary>
    ///  Метод с нашей бизнес-логикой, где будут использоваться создаваемые фабрикой объекты
    /// </summary>
    public void Run()
    { }
}

#endregion

#region Factory Method пример
abstract class BaseClass
{ }

/// <summary>
/// Конкретная реализация A
/// </summary>
class ConcreteClassA : BaseClass
{ }

/// <summary>
/// Конкретная реализация B
/// </summary>
class ConcreteClassB : BaseClass
{ }

/// <summary>
/// Абстрактный класс, от которого наследуются конкретные реализации
/// </summary>
abstract class Creator
{
    /// Фабричный метод, который будет переопределен в классах-наследниках
    public abstract BaseClass FactoryMethod();
}

/// <summary>
/// Конкретная реализация A
/// </summary>
class ConcreteCreatorA : Creator
{
    //  Переопределенный Фабричный метод здесь возвращает конкретную реализацию
    public override BaseClass FactoryMethod()
    {
        return new ConcreteClassA();
    }
}
/// <summary>
/// Конкретная реализация B
/// </summary>
class ConcreteCreatorB : Creator
{
    //  Переопределенный Фабричный метод здесь возвращает конкретную реализацию
    public override BaseClass FactoryMethod()
    {
        return new ConcreteClassB();
    }
}
#endregion