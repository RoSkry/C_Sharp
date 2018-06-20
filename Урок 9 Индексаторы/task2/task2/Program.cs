using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace SimpleProject
{
    public class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }

    enum Vendors { Samsung, Asus, LG };

    public class Shop
    {
        private Laptop[] laptopArr;

        public Shop(int size)
        {
            laptopArr = new Laptop[size];
        }
        public int Length
        {
            get { return laptopArr.Length; }
        }

        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptopArr.Length)
                {
                    return laptopArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < laptopArr.Length)
                {
                    laptopArr[index] = value;
                }
            }
        }

        public Laptop this[string name]
        {
            get
            {
                if (Enum.IsDefined(typeof(Vendors), name))
                {
                    return laptopArr[(int)Enum.Parse(typeof(Vendors), name)];
                }
                else
                {
                    return new Laptop();
                }
            }
            set
            {
                if (Enum.IsDefined(typeof(Vendors), name))
                {
                    laptopArr[(int)Enum.Parse(typeof(Vendors), name)] = value;
                }
            }
        }

        private int FindByPrice(double price)
        {
            for (int i = 0; i < laptopArr.Length; i++)
            {
                if (laptopArr[i].Price == price)
                {
                    return i;
                }
            }
            return -1;
        }

        public Laptop this[double price]
        {
            get
            {
                int index = FindByPrice(price);
                if (index >= 0)
                {
                    return this[index];
                }
                throw new Exception("Недопустимая стоимость.");
            }
            set
            {
                int index = FindByPrice(price);
                if (index >= 0)
                {
                    this[index] = value;
                }
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Shop laptops = new Shop(3);
            laptops[0] = new Laptop { Vendor = "Samsung", Price = 5200 };
            laptops[1] = new Laptop { Vendor = "Asus", Price = 4700 };
            laptops[2] = new Laptop { Vendor = "LG", Price = 4300 };

            try
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    WriteLine(laptops[i]);
                }
                WriteLine();

                WriteLine($"Производитель Asus: {laptops["Asus"]}.");

                WriteLine($"Производитель HP: {laptops["HP"]}.");

                laptops["HP"] = new Laptop(); // игнорирование

                WriteLine($"Стоимость 4300: {laptops[4300.0]}.");

                // недопустимая стоимость
                WriteLine($"Стоимость 10500: {laptops[10500.0]}.");

                laptops[10500.0] = new Laptop(); // игнорирование
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
