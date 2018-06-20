using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeption
{
  public class MyExeption:ApplicationException //1 cgjcj,
    {
        string _message;
        public DateTime TimeExeption { get; set; }
        public MyExeption()
        {
            _message = "Мое исключение";
            TimeExeption = DateTime.Now;
        }
        public override string Message
        {
            get { return _message; }
        }
    }
}
