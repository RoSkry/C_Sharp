using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
interface IFly
{
    void Fly();
}

interface ISwim
{
    void Swim();
}

interface IRun
{
    void Run();
}

abstract class Bird
{
    protected string name;

    public void IsEggs() { }

    //public abstract void Fly(); - проблема, так как существуют птицы, которые не летают - решение - Interface
}

class Duck : Bird, IFly, ISwim
{
    public Duck()
    {
        name = "Duck";
    }
    public void Fly() { Console.WriteLine(name); }
    public void Swim() { }
}

class Penguin : Bird, ISwim
{
    public Penguin()
    {
        name = "Penguin";
    }

    public void Swim() { }
}

class Ostrich : Bird, IRun // страус
{
    public Ostrich()
    {
        name = "Ostrich";
    }
    public void Run() { }
}

abstract class Insect // насекомое
{
    protected string name;
}

class Butterfly : Insect, IFly
{
    public Butterfly()
    {
        name = "Butterfly";
    }

    public void Fly() { Console.WriteLine(name); }
}

class Plane : IFly
{
    string name = "Plane";
    public void Fly() { Console.WriteLine(name); }
}

class Program
{
    static void Main(string[] args)
    {
        IFly[] iFly = { new Duck(), new Butterfly(), new Plane() };

        foreach (IFly item in iFly)
        {
            item.Fly();
        }

        // применение is и as
        Bird[] birds = { new Penguin(), new Ostrich(), new Duck() };

        foreach (Bird item in birds)
        {
            // необходимо вызвать метод Fly()
            if (item is IFly)
            {
                (item as IFly).Fly();
            }
        }

        Console.Read();
    }
}