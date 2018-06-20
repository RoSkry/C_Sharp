using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        enum Dayofweek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        enum CommodityType // тип товара
        {
            FrozenFood, Food, DomesticChemistry, BuildingMaterials, Petrol
        }

        enum TransportType // тип транспорта
        {
            Semitrailer, Coupling, Refrigerator, OpenSideTruck, FuelTruck
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 5");

            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number < 6)
            {
                CommodityType commodity = (CommodityType)Enum.GetValues(typeof(CommodityType)).GetValue(number - 1);

                TransportType transport = TransportType.Semitrailer;

                switch (commodity)
                {
                    case CommodityType.FrozenFood:
                        transport = TransportType.Refrigerator;
                        break;
                    case CommodityType.Food:
                        transport = TransportType.Semitrailer;
                        break;
                    case CommodityType.DomesticChemistry:
                        transport = TransportType.Coupling;
                        break;
                    case CommodityType.BuildingMaterials:
                        transport = TransportType.OpenSideTruck;
                        break;
                    case CommodityType.Petrol:
                        transport = TransportType.FuelTruck;
                        break;
                }
                Console.WriteLine("Для товара - {0} необходим транспорт - {1}.", commodity, transport);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }

            //DayOfWeek day = DayOfWeek.Friday;
            //    switch (day)
            //    {
            //        case DayOfWeek.Sunday:
            //            break;
            //        case DayOfWeek.Monday:
            //            break;
            //        case DayOfWeek.Tuesday:
            //            break;
            //        case DayOfWeek.Wednesday:
            //            break;
            //        case DayOfWeek.Thursday:
            //            break;
            //        case DayOfWeek.Friday:
            //            break;
            //        case DayOfWeek.Saturday:
            //            break;
            //        default:
            //            break;
            //    }

        }

        //public DayOfWeek NextDay(DayOfWeek day)
        //{
        //    return (day < DayOfWeek.Sunday) ? ++day : DayOfWeek.Monday;
        //}
        //            foreach (string item in args)
        //            {
        //                Console.WriteLine(item);
        //}
        //            Console.WriteLine(Environment.CommandLine);


    }
    }

        
    

