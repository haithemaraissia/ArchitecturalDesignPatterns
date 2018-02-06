using DesignPattern.DP.Behavioral.Observer.Subject;

namespace DesignPattern.DP.Behavioral.Observer.Observer
{
    public abstract class AbstractTrader
    {
        public abstract void Notify(Tick tick);
    }
}
