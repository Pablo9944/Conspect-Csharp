using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mission_Struct
{
    public class Train
    {
        string nameStop;
        int idTrain;
        DateTime timeGo;

        Train[] trains = new Train[8];


        public Train this[int index]
        {
            set
            {

                trains[index] = value;
              
            }
        
        
        }

        public override bool Equals(object obj)
        {
            for (int i = 0; i < trains.Length; i++)
            {

                if (trains[i].IDTrain == (obj as Train).idTrain)
                {
                    return false;
                }
            }
            return true;
        }

        public string this[int index, string m = " "]
        {
            get
            {
                if (index < trains.Length)
                {
                    return $"{trains[index].idTrain} {trains[index].nameStop} {trains[index].IDTrain}";
                }
                return "Вне массива";
            }

        }

        public int Length()
        {
            return trains.Length;
        }

        public string NameStop { get; set; }

        public int IDTrain { get; set; }

        public DateTime TimeGo { get; set; }


    }
}
