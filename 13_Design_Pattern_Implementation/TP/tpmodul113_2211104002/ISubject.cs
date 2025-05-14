using System.Collections.Generic;

namespace tpmodul113_NIM
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
