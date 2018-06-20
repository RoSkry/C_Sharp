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
                     
            st.show();

            st.setRating();
                 
            st.SredznachAdm();
           
           
            
            st.addRating();

            st.show();




        }
    }
}
