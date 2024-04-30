using System;
using UnityEngine;
using UnityEngine.UI;

namespace HW2.TaskMediator
{
    public class UpgradePanel : MonoBehaviour
    {
        [SerializeField] private Text _levelTitle;
        [SerializeField] private Button _levelUpButton;

        public event Action LevelUpEvent;

        private void OnEnable()
        {
            _levelUpButton.onClick.AddListener(OnLevelUpClick);
        }

        private void OnDisable()
        {
            _levelUpButton.onClick.RemoveListener(OnLevelUpClick);
        }

        public void UpdateLevelTitle(string title) => _levelTitle.text = title;

        private void OnLevelUpClick()
        {
            LevelUpEvent?.Invoke();
        }
    }
}
