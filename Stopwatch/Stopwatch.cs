using System;


namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _end;
        private bool _isRunning;
        private TimeSpan _interval;

        public TimeSpan Duration
        {
            get { return _interval; }
        }
        public void Start()
        {
           if (_isRunning == false)
            {
                _start = DateTime.Now;
                _isRunning = true;
            }
           else
           {
                throw new InvalidOperationException("The stopwatch is already running");
           }
        }

        public void Stop()
        {
            if (_isRunning == true)
            {
                _isRunning = false;
                _end = DateTime.Now;
                _interval = _interval + (_end - _start);
            } 
        }
    }
}
