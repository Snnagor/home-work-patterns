using UnityEngine;

namespace HW3.Task5
{
    public class PlayerBootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private RaceType _raceType;
        [SerializeField] private SpecializationType _specializationType;
        [SerializeField] private PassiveAbilityType _passiveAbilityType;

        private IStatsProvider _statsProvider;

        private void Awake()
        {
            _statsProvider = new RaceStats(_raceType);
            PrintStats(_raceType.ToString());
            _statsProvider = new SpecializationStats(_statsProvider, _specializationType);
            PrintStats(_specializationType.ToString());
            _statsProvider = new PassiveAbilityStats(_statsProvider, _passiveAbilityType);
            PrintStats(_passiveAbilityType.ToString());
            
            _player.Init(_statsProvider);
        }
        
        private void PrintStats(string type)
        {
            Debug.Log($"-------{type}------------------------------");
            Debug.Log($"Power: {_statsProvider.GetStats().Power}");
            Debug.Log($"Agility: {_statsProvider.GetStats().Agility}");
            Debug.Log($"Intelligence: {_statsProvider.GetStats().Intelligence}");
        }
    }
}