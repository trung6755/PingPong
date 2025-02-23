using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public class EventManager 
{
    public static event UnityAction TimerStart;
    public static event UnityAction TimerStop;
    public static event UnityAction<float> TimerUpdate;

    public static void OnTimerStart() => TimerStart?.Invoke();
    public static void OnTimerStop () => TimerStop?.Invoke();
    public static void OnTimerUpdate(float value) => TimerUpdate?.Invoke(value);

}
