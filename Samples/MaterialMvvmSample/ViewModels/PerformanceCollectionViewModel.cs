using System;
using System.Collections.Generic;
using System.Linq;

namespace MaterialMvvmSample.ViewModels
{
    public class PerformanceViewModel
    {
        public List<int> Items => Enumerable.Range(0, 100).ToList();
    }
}
