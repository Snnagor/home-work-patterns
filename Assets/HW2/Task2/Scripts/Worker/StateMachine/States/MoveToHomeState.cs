using UnityEngine;

namespace HW2.Task2
{
    public class MoveToHomeState: MoveWorkerState
    {
        public MoveToHomeState(IStateSwitcher stateSwitcher, IWorker worker) : base(stateSwitcher, worker)
        {
            TargetPosition = worker.HomePosition;
        }

        public override void Enter()
        {
            Debug.Log("Вышел домой");
        }

        public override void Exit()
        {
            Debug.Log("Пришел домой");
        }

        protected override void SetNextState()
        {
            StateSwitcher.SwitchState<RestState>();
        }
    }
}