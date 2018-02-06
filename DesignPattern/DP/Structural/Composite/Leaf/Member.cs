using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DP.Structural.Composite.Component;

namespace DesignPattern.DP.Structural.Composite.Leaf
{
    public class Member : IEmployee
    {
     
        public string Name { get; set; }
        public Member(string name)
        {
            Name = name;
        }
        public void PrintInfo()
        {
            Console.WriteLine(String.Format("            Name: {0} - Role : -Member", Name));
        }

    }
}
