using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLibrary.ObserverMode
{   
    public interface ISubject
    {
//        public void registerObserver(IObserver o);
//        public void removeObserver(IObserver o);
//        public void notifyObservers();
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers();
    }
}
