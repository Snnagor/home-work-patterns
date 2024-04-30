using System.Collections.Generic;

namespace HW2.Task2
{
    public class WorkerStateMachine: IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;

        public WorkerStateMachine(IWorker worker)
        {
            _states = new List<IState>()
            { 
                new RestState(this, worker),
                new MoveToWorkState(this, worker),
                new WorkingState(this, worker),
                new MoveToHomeState(this, worker)
            };
           
            _currentState = _states[0];
            _currentState.Enter();
        }

        public void SwitchState<T>() where T : IState
        {
            IState state = _states.Find(state => state is T);
            
            _currentState.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void Update() => _currentState.Update();
    }
}