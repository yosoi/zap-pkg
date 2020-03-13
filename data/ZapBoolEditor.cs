namespace Zap
{
  using UnityEditor;
  using UnityEngine;

  [CustomEditor(typeof(ZapBool))]
  public class ZapBoolEditor : Editor
  {
    public override void OnInspectorGUI()
    {
      DrawDefaultInspector();

      ZapBool zapBool = (ZapBool)target;
      zapBool.Value = EditorGUILayout.Toggle("Value", zapBool.Value);
    }
  }
}
