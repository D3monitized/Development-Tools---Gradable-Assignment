using System;
using System.Collections.Generic;
using DefaultNamespace.ScriptableEvents;
using UnityEngine;
using UnityEngine.Serialization;
using Variables;

namespace Asteroids
{
    public class AsteroidSet : ScriptableObject
    {
        public Dictionary<int, Asteroid> asteroids = new Dictionary<int, Asteroid>(); //Here we have a set of all asteroids in the game with their unique Id
        public void RegisterAsteroid(int instanceId, Asteroid asteroid) => asteroids.Add(instanceId, asteroid); //Here we add a new asteroid from the asteroid itself
        public void DeregisterAsteroid(int instanceId) => asteroids.Remove(instanceId); //Here we remove the asteroid from the set and later destroy it
    }

    public class AsteroidDestroyer : MonoBehaviour
    {
        [SerializeField] private IntObservable scoreObservable;
        [SerializeField] private ScriptableEventVector3 onAsteroidSplit; 

        public static AsteroidSet asteroidSet; 

        /*private List<Asteroid> _asteroids;
        private List<int> _asteroidIds;

        private Dictionary<int, Asteroid> _asteroidDict;*/

        private void Awake()
        {
            asteroidSet = ScriptableObject.CreateInstance<AsteroidSet>(); 
        }

        public void OnAsteroidHitByLaser(int instanceId)
        {
            // Get the asteroid
            Asteroid asteroid = asteroidSet.asteroids[instanceId];

            // Check if big or small
            float size = asteroid.currentSize; 

            // if it's big, we split it up.
            if(size >= .5f)
                onAsteroidSplit.Raise(asteroid.transform.position);
            
            // if small enough, we Destroy
            DestroyAsteroid(asteroid);
            DeregisterAsteroid(instanceId);
        }

        private void DeregisterAsteroid(int instanceId) => asteroidSet.DeregisterAsteroid(instanceId);

        private void DestroyAsteroid(Asteroid asteroid)
        {
            Destroy(asteroid.gameObject);
            scoreObservable.ApplyChange(1);
            //_asteroids.Remove()
        }

        /*public void RegisterAsteroid(Asteroid asteroid)
        {
            
        }*/
    }
}