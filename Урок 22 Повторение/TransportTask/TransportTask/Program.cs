using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> category = new List<string>();
            category.Add("Воздушный");
            category.Add("Морской");
            category.Add("Наземный");
            category.Add("Речной");

            List<Transport> means = new List<Transport>()
            {
                new Transport() {Means_of_transport="аэростат" ,ID_Cat=0},
                new Transport() {Means_of_transport="самолет" ,ID_Cat=0},
                new Transport() {Means_of_transport="судно",ID_Cat=1 },
                new Transport() {Means_of_transport="машина",ID_Cat=2 },
                 new Transport() {Means_of_transport="велосипед",ID_Cat=2 },
                new Transport() {Means_of_transport="поезд",ID_Cat=2},
                new Transport() {Means_of_transport="лодка",ID_Cat=3 },
                 new Transport() {Means_of_transport="каноэ",ID_Cat=3 },
            };

            //IEnumerable<IGrouping<string, Transport>> query1 = from i in means
            //                                        join cat in category on i.ID_Cat equals cat[i] into res
            //                                                   from r in res
            //                                                   select r;
           var  query = from i in means
                        group i by i.ID_Cat;
            foreach(var item in query)
            {
                Console.WriteLine(category[item.Key]);
                Console.WriteLine();
                foreach(var i in item)
                {
                    Console.WriteLine(i.Means_of_transport);
                }

            }                     
           



        }
    }
}
