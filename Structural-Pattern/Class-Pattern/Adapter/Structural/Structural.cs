using System;

namespace Adapter.Structural
{
    // Adapter Pattern - Simple     Judith Bishop Oct 2007
    // Simplest adapter using interfaces and inheritence

    // Existing way requests are implemented
    class Adaptee
    {
        // Provide full precision
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
    }

    // Required standard for requests
    interface ITarget
    {
        // Roug estimate required
        string Request(int i);
    }

    // Implementing the required standard via Adaptee
    class Adapter : Adaptee, ITarget {

        public string Request(int i)
        {
           return "Rough estimate is "+ (int)Math.Round(SpecificRequest(i, 3));
        }
    }
}
