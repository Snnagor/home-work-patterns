using System;
using UnityEngine;
using UnityEngine.UI;

namespace HW2.TaskMediator
{
    public class DamagePanel : MonoBehaviour
    {
        [SerializeField] private Text _dmgCountText;
        [SerializeField] private Button _damageButton;

        public event Action DamageEvent;

        private void OnEnable()
        {
            _damageButton.onClick.AddListener(OnDamageClick);
        }

        private void OnDisable()
        {
            _damageButton.onClick.RemoveListener(OnDamageClick);
        }

        public void UpdateDamageUI(int damage) => _dmgCountText.text = $"- {damage} HP";

        private void OnDamageClick()
        {
            DamageEvent?.Invoke();
        }
    }
}