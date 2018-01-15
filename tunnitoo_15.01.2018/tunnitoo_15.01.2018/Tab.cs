using System;
using System.Collections.Generic;

namespace tunnitoo_15._01._2018
{
    public class Tab
    {
        public IList<double> Entries { get; private set; } = new List<double>();

        public void Add(double hind)
        {
            Entries.Add(hind);
        }
    }
}