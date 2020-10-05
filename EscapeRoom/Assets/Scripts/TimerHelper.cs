using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimerHelper
{
    private static float StartTime;

    public static void startTime()
    {
        StartTime = Time.time;
        TimerDisplay.startTime = StartTime;
        TimerDisplay.startTimer();
    }

    public static void initialTime()
    {
        
        StartTime = PlayerPrefs.GetFloat("time");
        TimerDisplay.startTime = StartTime;
        TimerDisplay.startTimer();
    }

    public static float getStartTime()
    {
        return StartTime;
    }

    public static void saveTime()
    {
        PlayerPrefs.SetFloat("time", StartTime);
    }

}
