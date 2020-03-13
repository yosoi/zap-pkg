namespace Zap
{
  using UnityEditor;
  using UnityEngine;

  [CustomEditor(typeof(ZapEvent))]
  public class ZapEventEditor : Editor
  {
    public override void OnInspectorGUI()
    {
      DrawDefaultInspector();

      ZapEvent zapEvent = (ZapEvent)target;
      if (GUILayout.Button("Trigger Event"))
      {
        zapEvent.Trigger();
      }
    }
  }
}
