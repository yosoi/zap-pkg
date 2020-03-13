namespace Zap
{
  using System;
  using System.Collections.Generic;
  using UnityEngine;
  using UnityEngine.Events;

  public class ZapRelay : MonoBehaviour, IZapSubscriber
  {
    public List<ZapEvent> TriggerEvents;
    public UnityEvent OnTriggered;

    private void Subscribe(ZapEvent zapEvent) => zapEvent.Subscribe(this);
    private void Unsubscribe(ZapEvent zapEvent) => zapEvent.Unsubscribe(this);

    private void ToggleSubscriptions(bool isActive)
    {
      Action<ZapEvent> toggleAction = isActive
        ? (Action<ZapEvent>)Subscribe
        : (Action<ZapEvent>)Unsubscribe;

      foreach (ZapEvent triggerEvent in TriggerEvents)
      {
        toggleAction.Invoke(triggerEvent);
      }
    }

    private void OnDisable() => ToggleSubscriptions(false);
    private void OnEnable() => ToggleSubscriptions(true);

    void IZapSubscriber.Trigger() => OnTriggered?.Invoke();
  }
}
