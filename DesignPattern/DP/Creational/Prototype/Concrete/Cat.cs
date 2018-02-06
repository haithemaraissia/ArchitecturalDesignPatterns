using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Creational.Prototype.Prototype;

namespace DesignPattern.DP.Creational.Prototype.Concrete
{
    public class Cat : ICat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat()
        {
            
        }

        public ICat Clone()
        {
            return (ICat)MemberwiseClone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1}", Name, Age);
        }
    }
}
