using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1.Индексаторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Surname = new string[]
            {
                "Иванов",
                "Петров",
                "Сидоров"
            };
        
        
           Journal j = new Journal();
            for (int i = 0; i < Surname.Length; i++)
            {
                j[i] = new Workers(i, Surname[i]);    
            }
            
            for (int i = 0; i < j.Length; i++)
            {
                Console.WriteLine(j[i].number + " " + j[i].name);
            }

            foreach (Workers e in j)
            {
                Console.WriteLine(e.Number + " " + e.Name);
            }
        }
    
    
    
    
    }
}
class Workers
{
    public string name;
    public int number;
    public Workers(int number, string name)
    {
        this.number = number;   
        this.name = name;   
    }


    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}
class Journal
{
    List<Workers> journal = new List<Workers>();
   


    public Workers this[int index]
    {
        get { return journal[index]; }
        set { journal.Add(value); }
    }

    public int Length 
    {
        get { return journal.Count; }   
    }

    public IEnumerator GetEnumerator ()
    {
        foreach (var item in journal)
            yield return item;
    }
   
}