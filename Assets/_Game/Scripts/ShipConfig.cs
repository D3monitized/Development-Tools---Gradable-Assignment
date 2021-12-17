using UnityEngine;
using Variables;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Ship Config", menuName = "ScriptableObjects/ShipConfig", order = 0)]
    public class ShipConfig : ScriptableObject
    {
        [SerializeField] private FloatVariable _trottle;
        [SerializeField] private FloatVariable _rotation;
    }
    
}
