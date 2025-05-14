using System.Collections.Generic;

namespace tpmodul113_NIM
{
    public class NewsAgency : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string news;

        public void SetNews(string value)
        {
            news = value;
            Notify();
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(news);
            }
        }
    }
}
