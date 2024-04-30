using UnityEngine;

namespace HW2.Task2
{
    public abstract class TimeWorkerState: IState
    {
        
        protected readonly IStateSwitcher StateSwitcher;
        private float _currentTime = -2;
        
        public TimeWorkerState(IStateSwitcher stateSwitcher, IWorker worker)
        {
            StateSwitcher = stateSwitcher;
        }
        
        public abstract void Enter();

        public abstract void Exit();

        public void Update()
        {
            if (_currentTime > 0)
            {
                _currentTime -= Time.deltaTime;
            }
            else if(_currentTime > -1)
            {
                SetNextState();
                _currentTime = -2;
            }
        }
        
        protected abstract void SetNextState();

        protected void StartTimer(float time)
        {
            _currentTime = time;
        }
    }
}