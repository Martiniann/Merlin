using System;
using System.Collections.Generic;
using System.Text;

namespace Merlin.Actors
{
    interface IObservable
    {
        void Subscribe(IObserver observer);
    }
}
