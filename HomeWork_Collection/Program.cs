
using System.Linq;
using static Program;

class Program
{
    static void Main()
    {
        Collection mycoll = new Collection();

        Гражданин г = new Пенсионер() { Passport = 1 };
        
        mycoll.Add(г);

        Гражданин гр  = new Пенсионер() { Passport = 2 };

        mycoll.Add(гр);



    }
    public abstract class Гражданин
    {

    }
    public class Студент : Гражданин
    {

    }
    public class Пенсионер : Гражданин
    {
        public int Passport;
    }
    public class Рабочий : Гражданин
    {

    }
    public class Collection
    {
        public object[] CollectionPeople;

        int countCollectionPeople;

        Гражданин[] гражданин = new Гражданин[4];


        public Collection()
        {
            CollectionPeople = new object[4];
            countCollectionPeople = 0;
        }


        public Гражданин[] Resize(Гражданин []г)
        {
            var tempnewГражданинArray = new Гражданин[countCollectionPeople];

            for (int i = 0; i < гражданин.Length; i++)
            {
                tempnewГражданинArray[i] = г[i]; 
            }
            return tempnewГражданинArray;

        }
        //public override bool Equals(object obj)
        //{
        //    for (int i = 0; i < гражданин.Length; i++)
        //    {
        //        if (гражданин[i] is Пенсионер п)
        //        {
        //            п.Passport
        //        }
        //    }
        //}
        public void Add(object people)
        {
            if (countCollectionPeople > гражданин.Length)
                гражданин = Resize(гражданин);

            гражданин[countCollectionPeople] = people as Гражданин;
            countCollectionPeople++;

            if (гражданин[countCollectionPeople - 1] != null)
            {
                var tempList = new object[CollectionPeople.Length];
                
                for (int i = 0; i < гражданин.Length; i++)
                {
                    if (гражданин[i] is Пенсионер) && гражданин[i].Equals()
                    {
                        
                    }

                   
                    
                }
            }
            return;


        }
    }
}