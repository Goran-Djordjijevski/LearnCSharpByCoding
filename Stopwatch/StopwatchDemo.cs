using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Stopwatch
{
    public class StopwatchDemo
    {
        public TimeSpan Duration { get; set; }

        public void Start()
        {
            var stopwatch = new Stopwatch();
        }
    }
}
