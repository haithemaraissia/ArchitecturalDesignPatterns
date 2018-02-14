using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.DP.Structural
{
    #region Composite

    public interface Compositx
    {
        void DisplayInfo();
    }

    public class Componentx : Compositx
    {
        public List<Compositx> myList;
        public string Name { get; set; }

        public Componentx(string name)
        {
            Name = name;
            myList = new List<Compositx> { this };
        }

        public void AddMember(Compositx e)
        {
            if (e.GetType() == typeof(Componentx))
            {
                var elements = (Componentx)e;

                foreach (var element in elements.myList)
                {
                    myList.Add(element);
                }
            }
            else
            {
                myList.Add(e);
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine(String.Format("Name: {0}, --Role: Lead", Name));
        }

        public void Show()
        {
            foreach (var element in myList)
            {
                element.DisplayInfo();
            }
        }
    }

    public class Leafx : Compositx
    {
        public string Name { get; set; }

        public Leafx(string name)
        {
            Name = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(String.Format("             Name: {0}, --Role: Member", Name));
        }
    }

    #endregion


    #region Decorator

    public abstract class BakeComp
    {
        public abstract double GetPrice();
    }

    public class Cake : BakeComp
    {
        public override double GetPrice()
        {
            return 55;
        }
    }

    public class Deco : BakeComp
    {
        private BakeComp p;
        public Deco(BakeComp x)
        {
            p = x;
        }
        public override double GetPrice()
        {
            return p.GetPrice();
        }
    }

    public class CherryDeco : Deco
    {
        public CherryDeco(BakeComp x) : base(x)
        {
        }

        public override double GetPrice()
        {
            return 75;
        }
    }

    #endregion


    #region Bridge

    public abstract class Data
    {
        public IBrcom com;
        public abstract double getPrice();
    }

    public class API: IBrcom
    {
        public  double getPrice()
        {
            return 34;
        }
    }

    public interface IBrcom
    {
        double getPrice();
    }

    public class SendE:Data
    {
        public override double getPrice()
        {
            return 15;
        }
    }

    #endregion

}
