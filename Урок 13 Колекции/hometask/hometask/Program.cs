using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
//    Разработать класс очереди печати сотрудников.Предусмотреть в классе методы: помещение документа
//в очередь печати, извлечение следующего документа из очереди печати, проверка наличия документов в очереди.
//При помещении документа задается его приоритет, извлекаются в первую очередь документы с более высоким приоритетом.
    class Program
    {
        //создаем собственый клас, поле приоритет добавляем и соритируем
        static void Main(string[] args)
        {
            ArrayList w = new ArrayList();
            w.Add("tyu");
            w.Add("56");
            Container cont = new Container(w, 1);

        }
    }
}
