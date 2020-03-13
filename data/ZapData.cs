namespace Zap
{
  using System.Collections.Generic;
  using UnityEngine;
  using UnityEngine.Events;

  public abstract class ZapData<T, U> : ScriptableObject
    where U : UnityEvent<T>
  {
    private T _value;

    public U OnValueChanged;

    public T Value
    {
      get => _value;
      set
      {
        if (EqualityComparer<T>.Default.Equals(_value , value))
        {
          return;
        }

        _value = value;

        OnValueChanged?.Invoke(_value);
      }
    }
  }
}
