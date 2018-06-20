using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption
{
    class Program
    {
    
        static void Main(string[] args)
        { string str = null;
            try
            { 
            int n1, n2;
           

            try
            {
                n1 = int.Parse(Console.ReadLine());//только сострокой работает 
                n2 = Convert.ToInt32(Console.ReadLine());// к определеному из разных типов     

                Console.WriteLine($"Результат = {n1 / n2}");
                if(n2%2==0)
                {
                    throw new MyExeption();
                }
                str = "Bye";
            }
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                //catch (DivideByZeroException de)
                //{
                //    Console.WriteLine(de.Message);

                //}
                catch (MyExeption me)
                {
                 Console.WriteLine(me.Message);
                }
                //catch (FormatException fo)
                //{
                //    Console.WriteLine(fo.Message);
                //}   
                Console.WriteLine(str.Contains("Bye"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            finally
            {

                Console.WriteLine("The end");
            }

            //try { }
            //catch{cwl("Ошибка")}                           
        }                                     
    }                                         
}                                             
