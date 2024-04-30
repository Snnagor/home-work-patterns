using HW2.Task2.Configs;
using UnityEngine;

namespace HW2.Task2
{
    public abstract class MoveWorkerState: IState
    {
        private const float MinDistanceToTarget = 0.01f;
        
        protected readonly IStateSwitcher StateSwitcher;
        protected Vector3 TargetPosition;

        private readonly MoveWorkerStateConfig _moveStateConfig;
        private readonly Transform _transform;

        private float _speed;

        public MoveWorkerState(IStateSwitcher stateSwitcher, IWorker worker)
        {
            StateSwitcher = stateSwitcher;
            _transform = worker.Transform;
            _speed = worker.WorkerConfig.MoveStateConfig.Speed;
        }

        public abstract void Enter(); 

        public abstract void Exit();

        public void Update()
        {
            var direction = TargetPosition - _transform.position;
            _transform.Translate(direction.normalized * _speed * Time.deltaTime);
         
            if ( direction.magnitude <= MinDistanceToTarget)
            {
                SetNextState();
            }
        }

        protected abstract void SetNextState();
    }
}