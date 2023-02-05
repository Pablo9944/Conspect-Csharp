using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList__Mission_;

namespace _11._2_Mission
{
     class CarCollection<T> : MyList<T>
    {
        readonly MyList<string> carName;
        readonly MyList<DateTime> carYear;

        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();   
        }

        public void AddCar(string name, DateTime year) 
        {
            carName.Add(name);
            carYear.Add(year);
        }
        public  string this[int index]
        {
            get
            {
                if (index<= 0 && index < carName.Count)
                {
                    return carName[index] + " " + carYear[index]+"г";
                }
                return "Индекс вне границы массива";
            }
        }
        public int Length
        {
            get
            {
                return carName.Count;
            }
        }

        public void Remove()
        {
            carName.Clear();
            carYear.Clear();
        }

        public override string ToString()
        {
            string input = " ";
            for (int i = 0; i < carName.Count && i< carYear.Count; i++)
            {
                input += carName[i] + " " + carYear[i] + "г";
            }
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            return "Нет машин";
           
           
        }
    }
}
