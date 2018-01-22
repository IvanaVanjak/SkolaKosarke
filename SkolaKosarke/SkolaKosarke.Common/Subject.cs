using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Common
{
    public class Subject
    {
        List<Observer> observers;

        public Subject()
        {
            observers = new List<Observer>();
        }

        public void addObserver(Observer inObs)
        {
            observers.Add(inObs);
        }

        public void notifyObservers()
        {
            foreach (Observer obs in observers)
                obs.update();
        }
    }
}
