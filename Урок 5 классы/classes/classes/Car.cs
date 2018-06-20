using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Car
    {
        private string _driverName;
        private int _currSpeed;
        string _command;
        public Car(string name,int speed,string command):this(name,speed)
        {
            _command = command;
        }

        public Car() : this("Нет водителя", 0) { }
        public Car(string driverName) : this(driverName, 0) { }
        public Car(string driverName, int speed) // Главный конструктор
        {
            _driverName = driverName;
            _currSpeed = 10;
        }
        public void SetDriver(string driverName)
        {
            _driverName = driverName;
        }
        public void PrintState()        // Распечатка текущих данных
        {
            Console.WriteLine($"{_driverName} едет со скоростью {_currSpeed} км/ч.");
        }
        public void SpeedUp(int delta)  // Увеличение скорости
        {
            _currSpeed += delta;
        }
    }
}
