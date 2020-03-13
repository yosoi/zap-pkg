namespace Zap
{
  using UnityEditor;
  using UnityEngine;

  [CustomEditor(typeof(ZapInt))]
  public class ZapIntEditor : Editor
  {
    public override void OnInspectorGUI()
    {
      DrawDefaultInspector();

      ZapInt zapInt = (ZapInt)target;
      zapInt.Value = EditorGUILayout.IntField("Value", zapInt.Value);
    }
  }
}
