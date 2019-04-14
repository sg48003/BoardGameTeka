using System.Collections.Generic;

namespace BoardGameTeka.BaseLib
{
    public abstract class Subject
    {
        private readonly List<IObserver> _listObservers = new List<IObserver>();

        public void Attach(IObserver obs)
        {
            _listObservers.Add(obs);
        }

        public void Delete(IObserver obs)
        {
            _listObservers.Remove(obs);
        }

        public void NotifyObservers()
        {
            foreach (IObserver obs in _listObservers)
            {
                obs.UpdateView();
            }
        }
    }
}
