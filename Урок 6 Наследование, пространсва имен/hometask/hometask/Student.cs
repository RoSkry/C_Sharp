using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class Student
    {
        public Student() {}

        public Student(string surname,string name,string patronimic, string groupname,int age)
        {
            Surname = surname;
            _name = name;
            _patronymic = patronimic;
            _groupName = groupname;
            _age = age;

            rating[0] = new int[0];
            rating[1] = new int[0];
            rating[2] = new int[0];                
        }
        //фамилия
        public string Surname { get; set; }
        //private string _surname;
        //public string Surname
        //{
        //    get { return _surname; }
        //    set {  _surname=value; }
        //}
             //имя
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
                //очество
        private string _patronymic;
        public string Patronimic
        {
            get { return _patronymic; ; }
            set { _patronymic = value; }
        }
                   //группа
        private string _groupName;
        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }
               //возраст
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private int[][] rating=new int[3][];

        public void setRating()
        {
            Console.WriteLine("Введите количество оценок по програмированию");
           int _sizeProg = int.Parse(Console.ReadLine());
                             rating[0] = new int[_sizeProg];   
            for (int i = 0; i < rating[0].Length; i++)
            {
                Console.WriteLine("Введите {0}-тую оценку",i+1);
                int b = int.Parse(Console.ReadLine());
                rating[0][i] = b;

            }
           
           
            Console.WriteLine("Введите количество оценок по администрированию");
            int _sizeAdm = int.Parse(Console.ReadLine());
                rating[1] = new int[_sizeAdm];
            for (int i = 0; i < rating[1].Length; i++)
            {
                Console.WriteLine("Введите {0}-тую оценку", i + 1);
                int b = int.Parse(Console.ReadLine());
                rating[1][i] = b;

            }

               
            Console.WriteLine("Введите количество оценок по дизайну");
           int _sizeDesign = int.Parse(Console.ReadLine());
                    rating[2] = new int[_sizeDesign];

            for (int i = 0; i < rating[2].Length; i++)
            {
                Console.WriteLine("Введите {0}-тую оценку", i + 1);
                int b = int.Parse(Console.ReadLine());
                rating[2][i] = b;
            }
        }     //установка оценок
        public void getRating()
        {
            Console.WriteLine("Оценки по дизайну ");
             for (int i = 0; i < rating[0].Length; i++)
            {
                Console.Write(rating[0][i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Оценки по администрированию");
                for (int i = 0; i < rating[1].Length; i++)
            {
                Console.Write(rating[1][i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Оценки по дизайну ");
            for (int i = 0; i < rating[2].Length; i++)
            {
                Console.Write(rating[2][i]+" ");
            }
            Console.WriteLine();
        }     //получение всех оценок


            public void addRating()
        {
            int d = 1;
            while (d!=4) {
            Console.WriteLine("Выберете предмет 1-прораммирование,2-администрирование,3-дизайн, 4-выход");
             d = int.Parse(Console.ReadLine());
            int kol;
            int previous;
            if (d==1)
            {
                    previous = rating[0].Length;
                Console.WriteLine("Сколько оценок нужно добавить");
                   kol = int.Parse(Console.ReadLine());
                Array.Resize( ref rating[0], previous + kol);
               
                for(int i= previous; i< rating[0].Length; i++)
                {
                    Console.WriteLine("Введите {0}-тую по счету в массиве оценку", i);
                    rating[0][i] = int.Parse(Console.ReadLine());      
                }       
            }
           if (d == 2)
            {
                    previous = rating[1].Length;
                    Console.WriteLine("Сколько оценок нужно добавить");
                kol = int.Parse(Console.ReadLine());
                Array.Resize(ref rating[1], previous + kol);
                for (int i = previous; i < rating[1].Length; i++)
                {
                    Console.WriteLine("Введите {0}-тую по счету в массиве оценку", i);
                    rating[1][i] = int.Parse(Console.ReadLine());

                }
            }
          if (d == 3)
            {
                    previous = rating[2].Length;
                    Console.WriteLine("Сколько оценок нужно добавить");
                kol = int.Parse(Console.ReadLine());
                Array.Resize(ref rating[2], previous + kol);
                for (int i = previous; i < rating[2].Length; i++)
                {
                    Console.WriteLine("Введите {0}-тую по счету в массиве оценку", i);
                    rating[2][i] = int.Parse(Console.ReadLine());

                }
            }
            
           }
        }

                 //подсчет среднего значения
        public void SredznachProg()
        {
            double v = 0;
            double sred = 0;
            for (int i = 0; i < rating[0].Length; i++)
            {
                v += rating[0][i];
            }
            sred = v / rating[0].Length;
            Console.WriteLine("Среднее значение по програмированию " + sred);
        }
        public void SredznachAdm()
        {
            double v = 0;
            double sred = 0;
            for (int i = 0; i < rating[1].Length; i++)
            {
                v += rating[1][i];
            }
            sred = v / rating[1].Length;
            Console.WriteLine("Среднее администрированию " + sred);
        }
        public void SredznachDesign()
        {

            double v = 0;
            double sred = 0;
            for (int i = 0; i < rating[0].Length; i++)
            {
                v += rating[2][i];
            }
            sred = v / rating[0].Length;
            Console.WriteLine("Среднее значение по дизайну " + sred);
        }

           //  вывод информации о студенте
        public void show()
        {
            Console.WriteLine("Фамилия "+Surname);
            Console.WriteLine("Имя: " +_name);
            Console.WriteLine("Отчество: "+_patronymic);
            Console.WriteLine("Группа: "+_groupName);
            Console.WriteLine("Возраст: "+ _age);
            
            if(rating[0].Length!=0  || rating[1].Length != 0|| rating[2].Length != 0)
            getRating();


        }  

    }
}
