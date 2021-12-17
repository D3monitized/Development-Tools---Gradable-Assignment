using UnityEditor;
using UnityEngine;

namespace DefaultNamespace.ScriptableEvents.Editor
{
    [CustomEditor(typeof(ScriptableEventBase))]
    public class ScriptableEventEditor : UnityEditor.Editor
    {
        private ScriptableEventBase _target;
        
        // TODO our editor is not showing? :(
        public override void OnInspectorGUI()
        {
            _target = (ScriptableEventBase)target;

            base.OnInspectorGUI();
            
            if (GUILayout.Button("Debug Raise Event"))
            {
               _target.Raise();
            }

            // GUILayout
            // EditorGUI
            // EditorGUILayout
        }
    }
}
