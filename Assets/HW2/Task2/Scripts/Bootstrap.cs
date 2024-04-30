using UnityEngine;

namespace HW2.Task2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Transform _home;
        [SerializeField] private Transform _work;
        [SerializeField] private Worker _workerPrefab;

        private void Start()
        {
            CreateWorker();
        }

        private void CreateWorker()
        {
            Vector3 homePosition = _home.position;
            Vector3 position = new Vector3(homePosition.x, 0, homePosition.z);
            Worker newWorker = Instantiate(_workerPrefab, position, Quaternion.identity);
            newWorker.Init(homePosition, _work.position);
        }
    }
}