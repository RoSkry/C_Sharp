using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
               
            Menu m = new Menu();      //  дополнительный класс чтобы уменьшить код
            Money money1 = new Money() { Summa =m.Enter() };
                 
                while (true)
                {
                    try
                    {
                        switch (m.Choice())
                        {
                            case 1: Console.Clear(); Console.WriteLine(money1 += m.Sum()); break;
                            case 2:
                                {
                                    Money money2 = new Money() { Summa = m.Minus() };
                                    if (money2.Summa > money1.Summa)
                                    {
                                        throw new Bankrot_Exeption();
                                    }
                                    Console.Clear();
                                    Console.WriteLine(money1 -= money2);
                                }; break;
                            case 3:Console.Clear(); Console.WriteLine(money1 /= m.delenie());  ; break;
                            case 4: Console.Clear(); Console.WriteLine(money1*=m.umnozenie()); ; break;
                            case 5: Console.Clear(); Console.WriteLine(money1++); ; break;
                            case 6:
                                {
                                    money1--;
                                    if (money1.Summa < 0) throw new Bankrot_Exeption();
                                    Console.Clear();
                                    Console.WriteLine(money1);
                                }; break;
                            case 7:
                                {       Console.Clear();
                                    if (money1 == m.is_equal()) Console.WriteLine("Суммы равны");
                                    else Console.WriteLine("Суммы не равны");
                                    
                                    Console.WriteLine(money1);
                                }; break;
                            case 8:
                                {   Console.Clear();
                                    if (money1 > m.Sravnenie()) Console.WriteLine("Первая больше");
                                    else Console.WriteLine("Вторая больше");
                                    
                                    Console.WriteLine(money1);
                                }; break;
                            default: break;
                        }
                    }
                    catch (Bankrot_Exeption me)
                    {
                        Console.WriteLine(me.Message);
                    }
                }

              }
          
          
            catch(Exception me)
            {
                Console.WriteLine(me.Message);
            }
        }
                

            
    }
    }

