using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public float totalTime = 60.0f; // Set the total time here in seconds

    private float timeLeft;

    void Start()
    {
        timeLeft = totalTime;
        UpdateTimerText();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            // Do something when the timer reaches 0
            timerText.color = Color.yellow;
        }
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        string timeString = string.Format("{0:0}:{1:00}", minutes, seconds);
        timerText.text = timeString;
    }
}
