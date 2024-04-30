using UnityEngine;
using UnityEngine.UI;

namespace HW2.TaskMediator
{
    public class HpPanel : MonoBehaviour
    {
        [SerializeField] private Image _hpImage;
        [SerializeField] private Text _hpValue;

        public void UpdateValue(int currentHp, int maxHp)
        {
            _hpImage.fillAmount = (float) currentHp / maxHp;

            _hpValue.text = $"{currentHp}/{maxHp}";
        }
    }
}