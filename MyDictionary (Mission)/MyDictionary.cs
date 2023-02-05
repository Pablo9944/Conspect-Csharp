using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary__Mission_
{
    public class MyDictionary<Tkey,TValue>
    {
        Tkey[] key;
        TValue[] value;
        int length;

        public MyDictionary()
        {
            key = new Tkey[1];
            value = new TValue[1];
            length = 0;
        }

        public int Length => length;
        public string this[int index]
        {
            get
            {
                if (index <= key.Length && index >= 0)
                {
                    return key[index] + " " + value[index];
                }
                return "index за пределами массива";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if ((object)key[i] == (object)index)
                    {
                        return $"key - {key[i]} value - {value[i]}"; 
                    }
                    
                }
                return "-1";
            }
        }


        public void Add(Tkey key, TValue value)
        {


            Tkey[] tempKey = new Tkey[this.key.Length + 1];
            TValue[] tempValue = new TValue[this.value.Length + 1];
            length++;

            for (int i = 0; i < length; i++)
            {
                tempKey[i] = this.key[i];
                tempValue[i] = this.value[i];

            }
            tempKey[this.key.Length-1] = key;
            tempValue[this.key.Length-1] = value;
            this.key = tempKey;
            this.value = tempValue;



        }

        public string GetValue(int key)
        {
            if (key <= this.key.Length)
            {
                return (string)(object)value[--key];
            }
            return "-1";
        }
    }
}
