using HW2.Task2.Config;
using UnityEngine;

namespace HW2.Task2
{
    public interface IWorker
    {
        public Transform Transform { get; }
        public Vector3 HomePosition { get;}
        public Vector3 WorkPosition { get;}
        public WorkerConfig WorkerConfig { get; }
    }
}