using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop ch01 = new Clothes();
            ch01.Open();
            
        }
    }
    
    abstract class Shop()
    {
        public abstract void Open();
    }

    class Clothes : Shop
    {
        public override void Open()
        {
            Console.WriteLine("Clothes shop opens");
        }
    }
}