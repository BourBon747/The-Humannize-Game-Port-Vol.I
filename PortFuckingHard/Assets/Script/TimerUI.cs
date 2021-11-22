using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void OnEnable()
    {
        TimeManeger.OnMinuteChanged += UpdateTime;
        TimeManeger.OnHourChanged += UpdateTime;
    }

    private void OnDisable()
    {
        TimeManeger.OnMinuteChanged -= UpdateTime;
        TimeManeger.OnHourChanged -= UpdateTime;
    }

    private void UpdateTime()
    {
        timeText.text = $"{TimeManeger.Hour:00}:{TimeManeger.Minute:00}";
    }

}
