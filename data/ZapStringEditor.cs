namespace Zap
{
  using UnityEditor;
  using UnityEngine;

  [CustomEditor(typeof(ZapString))]
  public class ZapStringEditor : Editor
  {
    public override void OnInspectorGUI()
    {
      DrawDefaultInspector();

      ZapString zapString = (ZapString)target;
      zapString.Value = EditorGUILayout.TextField("Value", zapString.Value);
    }
  }
}
