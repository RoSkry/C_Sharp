using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Создать класс, описывающий студента.Предусмотреть в нем следующие моменты: фамилия, имя, отчество, группа, возраст, массив(зубчатый) оценок по программированию,
            //       администрированию и дизайну.А также добавить методы по работе с перечисленными данными: возможность установки/ получения оценки, получение среднего балла по заданному предмету,
            //распечатка данных о студенте.




            Student st = new Student("Skripnik", "Rostislav", "Yaroslavovich", "29PR31", 21);
                     
            st.show(); //вывод информации о студенте без учета  оценок

            st.setRating();  //задание оценок

            //подсчет среднего значения по трем предметам
            st.SredznachProg();
            st.SredznachAdm();
            st.SredznachDesign();
           
            st.addRating();  //добавление оценок
             
            st.show();   //вывод на экран вместе с оценками




        }
    }
}
