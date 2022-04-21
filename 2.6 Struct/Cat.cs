using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_Struct
{
    public struct Cat
    {

      
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }


        private string nickname; // Поля принято писать маленьки буквами

        public string Nickname   //  Свойства принято писать с большой буквы
        {
            get { return nickname; }
            set { nickname = value; }
        }

        public int Height {  get;  set; }

        public Cat(string Breed, string NickName, int Height)
        {
            this.breed = Breed;
            this.nickname = NickName;
            this.Height = Height;

        }

        









    }
	
}
