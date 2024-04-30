using System;
using UnityEngine;
using UnityEngine.UI;

namespace HW2.TaskMediator
{
    public class DefeatPanel : MonoBehaviour
    {
        [SerializeField] private Button _restartButton;

        public event Action RestartEvent;

        private void OnEnable()
        {
            _restartButton.onClick.AddListener(OnRestartClick);
        }

        private void OnDisable()
        {
            _restartButton.onClick.RemoveListener(OnRestartClick);
        }

        public void Show() => gameObject.SetActive(true);
        public void Hide() => gameObject.SetActive(false);

        private void OnRestartClick()
        {
            RestartEvent?.Invoke();
        }
    }
}