using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    [Serializable]
   public class Account:ISerializable
    {
        int _payment_per_day; //- оплата за день;
        int _days;//- количество дней;
        double _fine_for_one_day;// - штраф за один день задержки оплаты;
        int _days_of_delay;// - количество дней задержи оплаты;
        [NonSerialized]
         double _sum_without_fine;// - сумма к оплате без штрафа (вычисляемое поле);
        [NonSerialized]
        double _fine;// - штраф (вычисляемое поле);
        [NonSerialized]
        double _all_sum_to_pay;// - общая сумма к оплате (вычисляемое поле). 
        public static bool ObjectFormat { get; set; }
        public override string ToString()
        {
            return $"Оплата за день:{_payment_per_day}, количество дней {_days},штраф за один день {_fine_for_one_day}, количество дней задержки{_days_of_delay}, сумма к оплате без штрафа {_sum_without_fine}, штраф {_fine} ,общая сумма к оплате {_all_sum_to_pay} ";
        }
        public Account()
        {
            _payment_per_day = 10;
            _days = 30;
            _fine_for_one_day = 3;
            _days_of_delay = 2;
            _sum_without_fine = _payment_per_day * _days;
            _fine = _fine_for_one_day * _days_of_delay;
            _all_sum_to_pay = _fine + _sum_without_fine;
        }
        private Account(SerializationInfo info, StreamingContext context)
        {
            if(ObjectFormat)
            {                      
               _days =(int)info.GetInt32("_days");           
               _payment_per_day = (int)info.GetInt32("_payment_per_day");
               _fine_for_one_day= (double)info.GetInt32("_fine_for_one_day");
               _days_of_delay = (int)info.GetInt32("_days_of_delay");
               _fine = (double)info.GetDouble("_fine");
                _sum_without_fine = (double)info.GetDouble("_sum_without_fine");
                _all_sum_to_pay = (double)info.GetDouble("_all_sum_to_pay");
            }
            else
            {
                _days = (int)info.GetInt32("_days");
                _payment_per_day = (int)info.GetInt32("_payment_per_day");
                _fine_for_one_day = (double)info.GetInt32("_fine_for_one_day");
                _days_of_delay = (int)info.GetInt32("_days_of_delay");
            }

        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {

            if(ObjectFormat)
            { 
            info.AddValue("_payment_per_day",_payment_per_day);
            info.AddValue("_days",_days);
            info.AddValue("_fine_for_one_day",_fine_for_one_day);
            info.AddValue("_days_of_delay",_days_of_delay);
            info.AddValue("_sum_without_fine", _sum_without_fine);
            info.AddValue("_fine",_fine);
            info.AddValue("_all_sum_to_pay",_all_sum_to_pay);
            }
            else
            {
                info.AddValue("_payment_per_day", _payment_per_day);
                info.AddValue("_days", _days);
                info.AddValue("_fine_for_one_day", _fine_for_one_day);
                info.AddValue("_days_of_delay", _days_of_delay);
            }
            //var fields = typeof(Account).GetFields();
            //if(ObjectFormat)
            //{
            //    foreach(var item in fields)
            //    {
            //        info.AddValue(item.Name, item.GetValue(this));
            //    }
            //}
            //else
            //{
            //    foreach(var item in fields)
            //    {
            //        if(item.IsNotSerialized)
            //        {
            //            continue;
            //        }
            //        info.AddValue(item.Name, item.GetValue(this));
            //    }
            //}
        }
        public void Save()
        {
            SoapFormatter SoapFormat = new SoapFormatter();

            using (Stream wStream = new FileStream("invoice.soap", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                SoapFormat.Serialize(wStream, this);
            }
        }

        public void Load()
        {
            SoapFormatter SoapFormat = new SoapFormatter();

            using (Stream rStream = File.OpenRead("invoice.soap"))
            {
               Account temp = (Account)SoapFormat.Deserialize(rStream);
               Console.WriteLine(temp);
            }
        }
       


    }
}
