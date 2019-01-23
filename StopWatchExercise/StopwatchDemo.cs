using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatchExercise
{
    public class StopwatchDemo
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running = false;

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }

            _startTime = DateTime.Now;
            _running = true;

        }

        public void Stop()
        {
            if (!_running)
            {
                throw new InvalidOperationException("Stopwatch is not running!");
            }

            _endTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}
