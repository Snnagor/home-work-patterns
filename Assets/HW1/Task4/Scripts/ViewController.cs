using UnityEngine;

namespace HW1.Task4
{
    public class ViewController : MonoBehaviour
    {
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private GameObject _uiPanels;

        private void OnEnable()
        {
            _gameManager.EndGameEvent += EndGame;
        }

        private void OnDisable()
        {
            _gameManager.EndGameEvent -= EndGame;
        }

        public void PressButtonAllBalls()
        {
            _gameManager.StartGameAllBalls();
            _uiPanels.gameObject.SetActive(false);
        }
        
        public void PressButtonColorBalls()
        {
            _gameManager.StartGameColorBalls();
            _uiPanels.gameObject.SetActive(false);
        }

        private void EndGame()
        {
            _uiPanels.gameObject.SetActive(true);
        }
    }
}