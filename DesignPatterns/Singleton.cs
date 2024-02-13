using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class Singleton
    {
        private Singleton() { }
        private static Singleton instance;
        public static Singleton getInstance()
        {
            if(instance == null)
            {
                instance= new Singleton();
            }
            return instance;
        }
        static void Main(string[] args)
        {
        Singleton sc = Singleton.getInstance();
        }
    }
    
    
}
