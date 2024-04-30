using UnityEngine;

namespace HW2.Task2
{
    public class WorkingState: TimeWorkerState
    {
        private float _workingTime;
        
        public WorkingState(IStateSwitcher stateSwitcher, IWorker worker) : base(stateSwitcher, worker)
        {
            _workingTime = worker.WorkerConfig.TimeStateConfig.WorkingTime;
        }

        public override void Enter()
        {
            Debug.Log("Я пришел на работу. Начинаю работать.");
            StartTimer(_workingTime);
        }

        public override void Exit()
        {
            Debug.Log("Рабочее время закончилось. Собираюсь домой");
        }

        protected override void SetNextState()
        {
            StateSwitcher.SwitchState<MoveToHomeState>();
        }
    }
}