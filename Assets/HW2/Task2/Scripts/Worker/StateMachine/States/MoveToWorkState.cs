
using UnityEngine;

namespace HW2.Task2
{
    public class MoveToWorkState: MoveWorkerState
    {
        public MoveToWorkState(IStateSwitcher stateSwitcher, IWorker worker) : base(stateSwitcher, worker)
        {
            TargetPosition = worker.WorkPosition;
        }
        
        public override void Enter()
        {
            Debug.Log("Вышел");
        }

        public override void Exit()
        {
            Debug.Log("Пришел");
        }

        protected override void SetNextState()
        {
            StateSwitcher.SwitchState<WorkingState>();
        }
    }
}