using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Самодельный_Dictionary
{
     class Dictionary
    {
        string[] key = new string[5];
        string[] ENG = new string[5];
        string[] UA = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; UA[0] = "книга"; ENG[0] = "book";
            key[1] = "ручка"; UA[1] = "ручка"; ENG[1] = "pen";
            key[2] = "солнце"; UA[2] = "солнце"; ENG[2] = "sun";
            key[3] = "яблоко"; UA[3] = "яблуко"; ENG[3] = "apple"; 
            key[4] = "стол"; UA[4] = "стiл"; ENG[4] = "table"; 
        }

        public string this[int index]
        {
            get
            {
                if(index>=0 && index < key.Length)
                    return key[index] + " - " + UA[index] + " - " + ENG[index];
                return "Попытка обращения за пределы массива";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                
                        return key[i] + " - " + UA[i] + " - " + ENG[i];
                    
                    if (UA[i] == index)
              
                        return UA[i] + " - " + key[i] + " - " + ENG[i];
                  
                    if (ENG[i] == index)
                   
                        return ENG[i] + " - " + key[i] + " - " + UA[i];

                }
                return ($"нет перевода слова {index}");
            }
        }


    }
}
