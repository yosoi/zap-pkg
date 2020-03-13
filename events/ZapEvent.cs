namespace Zap
{
  using System.Collections.Generic;
  using UnityEditor;
  using UnityEngine;

  [CreateAssetMenu(menuName = "Zap/Event")]
  public class ZapEvent : ScriptableObject
  {
    private List<IZapSubscriber> subscribers;

    public void Reset()
    {
      subscribers = new List<IZapSubscriber>();
    }

    public void Trigger()
    {
      if (subscribers == null)
      {
        return;
      }
      
      foreach (IZapSubscriber subscriber in subscribers)
      {
        subscriber.Trigger();
      }
    }

    public void Subscribe(IZapSubscriber subscriber)
    {
      if (subscribers == null)
      {
          Reset();
      }

      subscribers.Add(subscriber);
    }

    public void Unsubscribe(IZapSubscriber subscriber)
    {
      if (subscribers == null)
      {
        return;
      }

      subscribers.Remove(subscriber);
    }
  }
}
