
class Program
{
    static void Main()
    {
        #region Виды структурных паттернов
        // ADAPTER - адаптер
        // очень распространенный паттерн, позволяющий работать вместе объектам с несовместимыми интерфейсами.
        // Применение данного паттерна очень широко, так как в программировании очень часто необходимые нам ресурсы поддерживают разные способы доступа.
        // И данные из этих ресурсов бывают нам нужны в нашем приложении одновременно.
        // Применение данного паттерна очень широко, так как в программировании очень часто необходимые нам ресурсы поддерживают разные способы доступа.
        // И данные из этих ресурсов бывают нам нужны в нашем приложении одновременно.

        // COMPOSITE - компоновщик
        // FACADE - фасад
        #endregion

        #region 

        #endregion

        #region 

        #endregion
    }
}
#region ADAPTER пример
class Client
{
    public void Request(DataSource dataSource)
    {
        dataSource.GetData();
    }
}

/// <summary>
/// Класс - источник ресурса, к которому нужно подключиться
/// </summary>
class DataSource
{
    public virtual void GetData()
    { }
}

/// <summary>
/// Класс - потребитель ресурса
/// </summary>
class DataConsumer
{
    public void GetSpecificData()
    { }
}
/// <summary>
/// Адаптер для подключения
/// </summary>
class Adapter : DataSource
{
    private DataConsumer _dataConsumer = new DataConsumer();

    // метод для получения ресурса
    public override void GetData()
    {
        _dataConsumer.GetSpecificData();
    }
}


#endregion

#region 

#endregion

#region 


#endregion