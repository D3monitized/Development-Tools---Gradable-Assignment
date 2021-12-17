using System;
using UnityEngine;
using DefaultNamespace.ScriptableEvents;

namespace Ship
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Laser _laserPrefab;
        [SerializeField] private ScriptableEventInt onLaserShot; 
        
        private int lasersShot; 

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Shoot();
        }
        
        private void Shoot()
        {
            var trans = transform;
            Instantiate(_laserPrefab, trans.position, trans.rotation);
            lasersShot++;
            onLaserShot.Raise(lasersShot);
        }
    }
}
