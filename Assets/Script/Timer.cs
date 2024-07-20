using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Timer : MonoBehaviour
{
    private TMP_Text _timerText;
    enum TimerType { Countdown}
    [SerializeField] private TimerType _timerType;
    [SerializeField] private float timeToDisplay = 180.0f;

    private bool _isRunning;

    private void Awake()
    {
        _timerText = GetComponent<TMP_Text>();

    }

    private void OnEnable()
    {
        EventManager.TimerStart += EventManagerOnTimerStart;
        EventManager.TimerStop += EventManagerOnTimerStop;
        EventManager.TimerUpdate += EventManagerOnTimerUpdate;

    }private void OnDisable()
    {
        EventManager.TimerStart -= EventManagerOnTimerStart;
        EventManager.TimerStop -= EventManagerOnTimerStop;
        EventManager.TimerUpdate -= EventManagerOnTimerUpdate;
    }

    private void EventManagerOnTimerStart() => _isRunning = true;
    
    private void EventManagerOnTimerStop() => _isRunning = false;

    private void EventManagerOnTimerUpdate(float value) => timeToDisplay += value;

    private void Update()
    {
        if(!_isRunning) return;
        if(_timerType == TimerType.Countdown && timeToDisplay < 0.0f) return;
        timeToDisplay += _timerType == TimerType.Countdown ? -Time.deltaTime : Time.deltaTime;

        TimeSpan timeSpan = TimeSpan.FromSeconds(timeToDisplay);
        _timerText.text = timeSpan.ToString(format:@"mm\:ss");

        
    }

    public void TimeUp()
    {

    }

}
