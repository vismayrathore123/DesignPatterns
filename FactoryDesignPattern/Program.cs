using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ConcreteProductA: IProduct
    {
        public void operation()
        {
            Console.WriteLine("Hello ConcereteProduct A ");
        }
    }
    public class ConcreteProductB: IProduct
    {
        public void operation()
        {
            Console.WriteLine("Hello concreteProduct B");
        }
    }
    public class ProductFactory
    {
        public IProduct CreateProduct  (int type)
        {
            switch (type)
            {
                case 0: 
                    return new ConcreteProductA();
                case 1: 
                    return new ConcreteProductB();
                default:
                    throw new ArgumentException("invalid product type ");
            }
        }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            ProductFactory fck= new ProductFactory();   
            IProduct productA= fck.CreateProduct (1);
            IProduct productB=fck.CreateProduct (0);

            productA.operation();
            productB.operation();
        }
    }
}
