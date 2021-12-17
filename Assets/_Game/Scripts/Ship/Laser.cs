using System;
using Asteroids;
using DefaultNamespace.ScriptableEvents;
using UnityEngine;

namespace Ship
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Laser : MonoBehaviour
    {
        [Header("Values:")]
        [SerializeField] private float _speed = 0.2f;

        private Rigidbody2D _rigidbody;
        private float _lifetime;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    
        private void FixedUpdate()
        {
            var trans = transform;
            _rigidbody.MovePosition(trans.position + trans.up * _speed);
        }
    }
}
