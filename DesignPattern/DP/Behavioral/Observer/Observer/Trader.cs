using System;
using DesignPattern.DP.Behavioral.Observer.Subject;

namespace DesignPattern.DP.Behavioral.Observer.Observer
{
    public class Trader: AbstractTrader
    {
        public string Name { get; set; }

        public Trader(string n)
        {
           Name = n;
        }
        public override void Notify(Tick tick)
        {
            Console.WriteLine(string.Format("Trader: {0}, has been update for Tick: {1} - With Price: {2}", Name, tick.Name, tick.Price));
        }
    }
}
