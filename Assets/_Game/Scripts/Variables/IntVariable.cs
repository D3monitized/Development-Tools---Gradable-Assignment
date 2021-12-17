using System;
using UnityEngine;

namespace Variables
{
    // TODO Can we use generics to avoid duplication?
    [CreateAssetMenu(fileName = "new FloatVariable", menuName = "ScriptableObjects/Variables/IntVariable")]
    public class IntVariable : ScriptableObject
    {
        [SerializeField] private int _value;

        private int _currentValue;

        public int Value => _currentValue;

        public virtual void ApplyChange(int change)
        {
            _currentValue += change;
        }

        private void OnEnable()
        {
            _currentValue = _value;
        }
    }

    public class VariableBase<T> : ScriptableObject
    {
        
    }
}
