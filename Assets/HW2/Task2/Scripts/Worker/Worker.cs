using HW2.Task2.Config;
using UnityEngine;

namespace HW2.Task2
{
    public class Worker : MonoBehaviour, IWorker
    {
        [SerializeField] private WorkerConfig _workerConfig;
        public WorkerConfig WorkerConfig => _workerConfig;
        
        public Transform Transform => transform;
        public Vector3 HomePosition => _homePosition;
        public Vector3 WorkPosition { get; private set; }

        private WorkerStateMachine _stateMachine;

        private Vector3 _homePosition;

        public void Init(Vector3 home, Vector3 work)
        {
            _homePosition = home;
            WorkPosition = work;
            _stateMachine = new WorkerStateMachine(this);
        }

        private void Update()
        {
            _stateMachine.Update();
        }
    }
}