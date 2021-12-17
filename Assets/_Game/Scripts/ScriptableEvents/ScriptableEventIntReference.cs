using UnityEngine;
using Variables;

namespace DefaultNamespace.ScriptableEvents
{
    [CreateAssetMenu(fileName = "new ScriptableEventIntReference", menuName = "ScriptableObjects/ScriptableEvent-IntReference", order = 0)]
    public class ScriptableEventIntReference : ScriptableEvent<IntReference>
    {
        public void Raise(int newValue)
        {
            Raise(new IntReference(newValue));
        }
    }
}
