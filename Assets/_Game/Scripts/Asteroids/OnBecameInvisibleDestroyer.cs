using UnityEngine;

namespace Asteroids
{
    public class OnBecameInvisibleDestroyer : MonoBehaviour
    {
        [SerializeField] private GameObject _toDestroy;
        
        private void OnBecameInvisible()
        {
            Destroy(_toDestroy);
        }
    }
}