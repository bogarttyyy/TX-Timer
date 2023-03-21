using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public TMP_Text stopwatchText;
    public Button lapButton;

    public Transform lapGroup;
    public TMP_Text lapText;

    private float startTime;
    private float lapTime;
    private int lapCount;

    void Start()
    {
        startTime = Time.time;
        lapTime = startTime;
        lapCount = 1;
        lapButton.onClick.AddListener(RecordLap);
        lapText = Instantiate(lapText, lapGroup, false);

    }

    void Update()
    {
        float elapsedTime = Time.time - startTime;
        float lapElapsedTime = Time.time - lapTime;

        string timeString = FormatTime(elapsedTime);
        string lapTimeString = FormatTime(lapElapsedTime);

        stopwatchText.text = timeString;
        lapText.text = $"Lap {lapCount}: {lapTimeString}";
    }

    void RecordLap()
    {
        lapText = Instantiate(lapText, lapGroup, false);
        float lapElapsedTime = Time.time - lapTime;
        lapTime = Time.time;
        lapCount++;
        string lapTimeString = FormatTime(lapElapsedTime);

        lapText.text = $"\nLap {lapCount}: {lapTimeString}";
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        int milliseconds = Mathf.FloorToInt((time * 1000) % 1000);
        string timeString = string.Format("{0:0}:{1:00}.{2:000}", minutes, seconds, milliseconds);
        return timeString;
    }
}
