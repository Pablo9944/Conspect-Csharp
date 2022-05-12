using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Агрегация_и_композиция
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }
    }

      /*При проектировании классов следует учитывать следующие общие рекомендации:

       1) Композиция предпочтительнее наследования.
       2) Агрегация предпочтительнее композиции.*/


    #region Ассоциация 


    //class MotherBoard
    //{
    //}

    //class SystemUnit
    //{
    //    private MotherBoard motherBoard;
    //}

    #endregion

    #region Композиция


    //    class MotherBoard
    //    {
    //    }
    //    class SystemUnit
    //    {
    //        private MotherBoard motherBoard;

    //        public SystemUnit()
    //        {
    //            motherBoard = new MotherBoard();
    //        }
    //    }

    #endregion

    #region Агрегация

    //class MotherBoard
    //{
    //}
    //class SystemUnit
    //{
    //    private MotherBoard motherBoard;

    //    public SystemUnit(MotherBoard motherBoard)
    //    {
    //        this.motherBoard = motherBoard;
    //    }
    //}
    #endregion
}
