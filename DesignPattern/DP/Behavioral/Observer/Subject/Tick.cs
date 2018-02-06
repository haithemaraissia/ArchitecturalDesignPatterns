using System.Collections.Generic;
using DesignPattern.DP.Behavioral.Observer.Observer;

namespace DesignPattern.DP.Behavioral.Observer.Subject
{
    public class Tick : AbstractTick
    {
        #region Fields

        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Update();
                }

            }
        }
        public string Name { get; set; }

        private List<Trader> _observerList = new List<Trader>();

        #endregion

        public Tick(string n, double p)
        {
            Name = n;
            _price = p;
        }

        #region Members

        public void Add(Trader t)
        {
            _observerList.Add(t);
        }
        public void Remove(Trader t)
        {
            _observerList.Remove(t);
        }
        public override void Update()
        {
            foreach (var t in _observerList)
            {
                t.Notify(this);
            }
        }

        #endregion
    }
}
