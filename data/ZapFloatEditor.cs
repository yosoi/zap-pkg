namespace Zap
{
  using UnityEditor;
  using UnityEngine;

  [CustomEditor(typeof(ZapFloat))]
  public class ZapFloatEditor : Editor
  {
    public override void OnInspectorGUI()
    {
      DrawDefaultInspector();

      ZapFloat zapFloat = (ZapFloat)target;
      zapFloat.Value = EditorGUILayout.FloatField("Value", zapFloat.Value);
    }
  }
}
