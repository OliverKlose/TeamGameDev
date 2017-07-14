using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestGameClient
{
    public class GameTime
    {
        private float _deltaTime = 0f;
        private float _timeScale = 1f;

        public float TimeScale
        {
            get { return _timeScale; }
            set { _timeScale = value; }
        }

        public float DeltaTime
        {
            get { return _deltaTime * _timeScale; }
            private set { _deltaTime = value; }
        }

        public float DeltaTimeUnscaled
        {
            get { return _deltaTime; }
        }

        public float totalTimeElapsed
        {
            get;
            private set;
        }

        public GameTime()
        {
        }

        public void Update(float p_deltaTime, float p_totalTimeElapsed)
        {
            this._deltaTime = p_deltaTime;
            this.totalTimeElapsed = p_totalTimeElapsed;
        }
    }
}
