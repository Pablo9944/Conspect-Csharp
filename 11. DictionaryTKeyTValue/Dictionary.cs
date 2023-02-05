using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList__Mission_;

namespace _11.DictionaryTKeyTValue
{
    public class Dictionary <TKey,TValue> 
    {
        readonly MyList<TKey> key;
        readonly MyList<TValue> value;

        public Dictionary()
        {
            key = new MyList<TKey>();
            value = new MyList<TValue>();

        }

        public void AddDictionary(TKey key,TValue value)
        {
            this.key.Add(key);
            this.value.Add(value);
        }


        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Count)
                {
                    return key[index] + " " + value[index];
                }
                return "Вне границы массива";
            }
        }
        public string this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if ((object)key[i] == (object)index)
                    {
                        return (string)(object)key[i];
                    }
                }
                return "Index вне границ массива";
            }
        }

        

    }
}
