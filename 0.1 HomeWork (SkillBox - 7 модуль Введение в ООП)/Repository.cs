using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0._1_HomeWork__SkillBox___7_модуль_Введение_в_ООП_
{
    public struct Repository
    {

        public Workers[] worker;

        public int counter { get; set; }
        private string path { get; set; }

        /// <summary>
        /// Конструткор,инициализирует параметры,а также создает файл для записи
        /// </summary>
        /// <param name="path"></param>
        /// <param name="worker"></param>
        public Repository(string path,params Workers[] worker)
        {
            this.path = path;
            counter = 0;
            this.worker = worker;
            
            
              
                
            
        }
    
        /// <summary>
        /// Метод записывает в файл User-ов,принимает параметр для определения их колличества
        /// </summary>
        /// <param name="count"></param>
        public void AddWorker(int count)
        {
            for (int i = 0; i < count; i++)
            {
                using (StreamWriter sw = new StreamWriter(@"D:\Workers.csv", true, Encoding.Default))
                {
                    sw.WriteLine((i+1)+ ";"
                                + DateTime.Now + ";"
                                + $"{worker[0].Lastname}_{i};" 
                                + $"{worker[0].FirstName}_{i};" 
                                + $"{worker[0].SecondName}_{i};"  
                                + worker[0].Age 
                                + worker[0].Height 
                                + worker[0].BurnDay + ";"
                                + worker[0].BurnCity);

                }
                counter++;
            }
        }


        /// <summary>
        /// Метод считывает из файла и выводит на консоль
        /// </summary>
        public void ReadWorker()
        {
            using (StreamReader st = new StreamReader(path, Encoding.Default))
            {
                while (!st.EndOfStream)
                {
                   string[]myArr = st.ReadLine().Split(';');
                    string Info = string.Join(" ", myArr);
                    Console.WriteLine(Info);
                   
                  
                     
                }
            }
          
            
        }
        
        /// <summary>
        /// Внутренний метод обработки информации (принимает строки в массив)
        /// </summary>
        /// <returns></returns>
        public string[] Settings()
        {
           
            string[] ArrUsers = new string[counter];
            using (StreamReader st = new StreamReader(path, Encoding.Default))
            {
               
                int index = 0;
                while (!st.EndOfStream)
                {
                    string[]myArr = st.ReadLine().Split(';');
                    string Info = string.Join(" ", myArr);
                    ArrUsers[index] += Info;
                    index++;
                }
            
            }
            return ArrUsers;
        }
       
        
        
        
        /// <summary>
        /// Метод удаляет User по заданному индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string [] DelUsers(int index)
        {
            
            string[] arrUsers = Settings();
            string[] temp = new string[arrUsers.Length -1];
            if (index < temp.Length)
            {

                for (int i = 0; i <= index && index < temp.Length; i++)
                {
                    temp[i] += arrUsers[i];
                }
                for (int i = index; i < arrUsers.Length && i < temp.Length; i++)
                {
                    temp[i] += arrUsers[i];
                }

                FileInfo fi = new FileInfo(path);
                fi.Delete();


                for (int i = 0; i < temp.Length; i++)
                {
                    using (StreamWriter sw = new StreamWriter(@"D:\Workers.csv", true, Encoding.Default))
                    {
                        sw.WriteLine((i + 1) + ";"
                                    + DateTime.Now + ";"
                                    + $"{worker[0].Lastname}_{i};"
                                    + $"{worker[0].FirstName}_{i};"
                                    + $"{worker[0].SecondName}_{i};"
                                    + worker[0].Age
                                    + worker[0].Height
                                    + worker[0].BurnDay + ";"
                                    + worker[0].BurnCity);

                    }
                    counter++;
                }

                return (arrUsers = temp);
            }
         
            return arrUsers;
        }



  



    }
}
