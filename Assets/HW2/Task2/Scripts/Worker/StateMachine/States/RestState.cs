using UnityEngine;

namespace HW2.Task2
{
    public class RestState: TimeWorkerState
    {
        private float _restTime;
        
        public RestState(IStateSwitcher stateSwitcher, IWorker worker) : base(stateSwitcher, worker)
        {
            _restTime = worker.WorkerConfig.TimeStateConfig.RestTime;
        }
        
        public override void Enter()
        {
            Debug.Log("Я дома! Отдыхаю");
            StartTimer(_restTime);
        }

        public override void Exit()
        {
            Debug.Log("Время отдыха закончилось! Выхожу на работу");
        }

        protected override void SetNextState()
        {
            StateSwitcher.SwitchState<MoveToWorkState>();
        }
    }
}