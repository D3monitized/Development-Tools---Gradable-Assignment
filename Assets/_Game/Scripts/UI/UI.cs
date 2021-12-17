using System;
using DefaultNamespace.ScriptableEvents;
using TMPro;
using UnityEngine;
using Variables;

namespace UI
{
    public class UI : MonoBehaviour
    {
        [Header("Health:")]
        [SerializeField] private IntVariable _healthVar;
        [SerializeField] private TextMeshProUGUI _healthText;
        [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;


        [Header("Score:")]
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private ScriptableEventIntReference _onScoreChangedEvent;
        
        [Header("Timer:")]
        [SerializeField] private TextMeshProUGUI _timerText;
        
        [Header("Laser:")]
        [SerializeField] private TextMeshProUGUI _laserText;
        
        private void Start()
        {
            SetHealthText($"Health: {_healthVar.Value}");
        }

        public void OnHealthChanged(IntReference newValue) =>  SetHealthText($"Health: {newValue.GetValue()}");

        public void OnScoreChanged(IntReference value) => SetScoreText($"Asteroids Destroyed: {value.GetValue()}");

        public void OnGameTimeUpdated(int value) => SetTimerText($"Time: {value.ToString()}");

        public void OnLaserShot(int value) => SetLaserText($"Lasers Shot: {value.ToString()}");
        
        private void SetHealthText(string text)
        {
            _healthText.text = text;
        }
        
        private void SetScoreText(string text)
        {
            _scoreText.text = text;
        }
        
        private void SetTimerText(string text)
        {
            _timerText.text = text;
        }
        
        private void SetLaserText(string text)
        {
            _laserText.text = text;
        }
    }
}
