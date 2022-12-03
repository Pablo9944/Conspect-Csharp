
using System.Collections;

class Program
{
    static void Main()
    {
        #region Множества
        // IEnumerable<T> - последовательности
        // ICollection - коллекции
        // IList<T> - списки
        // IDictionary<K,V> - словари
        #endregion

        Progression progression = new Progression(100);
        foreach (var i in progression)
        {
            Console.WriteLine(i);
        }
        


    }
}
class Progression : IEnumerable<int>
{
    private readonly int _itemCount;
    public Progression(int itemCount)
    {
        _itemCount = itemCount;
    }

    public IEnumerator<int> GetEnumerator()
    {
        int current = 1;
        for (int i = 0; i < _itemCount; i++)
        {
            if (i == 0) yield return 1;
            current += 3;
            yield return current;
        }
        //return new ProgressionIterator(_itemCount);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
class ProgressionIterator:IEnumerator<int>
{
    private readonly int _itemCount;
    private int _position;
    private int _current;
    public ProgressionIterator(int itemCount)
    {
        _itemCount = itemCount;
        _position = 1;
        _current = 0;
    }

    public void Dispose()
    {
       
    }

    public bool MoveNext()
    {
        if (_position > 0)
            _current += 3;

        if (_position < _itemCount)
        {
            _position++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _position = 1;
        _current = 0;
    }

    public int Current
    {
        get { return _current; }
    }
    object IEnumerator.Current
    {
        get { return Current; }
    }
}