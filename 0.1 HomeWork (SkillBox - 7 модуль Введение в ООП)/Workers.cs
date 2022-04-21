using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1_HomeWork__SkillBox___7_модуль_Введение_в_ООП_
{
    public struct  Workers
    {
        #region Поля
        

        private DateTime dateTimeCreate;

        public DateTime DateTimeCreate
        {
            get { return dateTimeCreate; }
            set { dateTimeCreate = value; }
        }

        private string lastName;

        public string Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string secondName;
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private int burnDay;

        public int BurnDay
        {
            get { return burnDay; }
            set { burnDay = value; }
        }

        private string burnCity;

        public string BurnCity
        {
            get { return burnCity; }
            set { burnCity = value; }
        }

        #endregion
        public Workers( 
                       DateTime dateTimeCreate, 
                       string lastName, 
                       string firstName, 
                       string secondName, 
                       int age, 
                       int height, 
                       int burnDay, 
                       string burnCity)


        {
           
            this.dateTimeCreate = dateTimeCreate;
            this.lastName = lastName;
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
            this.height = height;
            this.burnDay = burnDay;
            this.burnCity = burnCity;

        }
    }
}
