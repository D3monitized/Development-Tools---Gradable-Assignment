using DefaultNamespace.ScriptableEvents;
using UnityEngine;

namespace Variables
{
    [CreateAssetMenu(fileName = "new Int Observable", menuName = "ScriptableObjects/Variables/Int Observable")]
    public class IntObservable : IntVariable
    {
        [SerializeField] private ScriptableEventIntReference _onValueChangedEvent;
        
        public override void ApplyChange(int change)
        {
            base.ApplyChange(change);
            // TODO I don't love creating a new instance here
            _onValueChangedEvent.Raise(new IntReference(this));
        }
    }
}
