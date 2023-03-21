using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public TMP_Text clockText;

    void Start()
    {
        // Get the local time on the computer
        DateTime now = DateTime.Now;

        // Set the clock text to the local time
        clockText.text = now.ToString("HH:mm:ss");
    }

    void Update()
    {
        // Get the local time on the computer
        DateTime now = DateTime.Now;

        // Set the clock text to the local time
        clockText.text = now.ToString("HH:mm:ss");
    }
}
