using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Classwork
{
    class Car
    {
        private int _currentSpeed = -1;

        public delegate void Driving(int currentSpeed);
        public event Driving OnDriving;

        public delegate void Stop();
        public event Stop OnStop;

        public delegate void Speeding();
        public event Speeding OnSpeeding;

        public int CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
            set
            {
                _currentSpeed = value;
                if (OnDriving != null)
                {
                    OnDriving(_currentSpeed);
                }

                if(_currentSpeed > 120 && OnSpeeding != null)
                {
                    OnSpeeding();
                }
                if(_currentSpeed == 0 && OnStop != null)
                {
                    OnStop();
                }
            }
        }



    }
}
