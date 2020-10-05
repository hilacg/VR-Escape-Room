using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour
{
    public static float startTime;
    public static float globaltime;
    private static bool timerOn = false;
    private static bool gameEnd = false;
    [SerializeField] public Text timerText;

    void Update()
    {
        if (timerOn)
        {
            if (!gameEnd)
            {
                globaltime = Time.time - startTime;
                string minutes = ((int)globaltime / 60).ToString();
                string seconds = (globaltime % 60).ToString("f2");
                timerText.text = "Time: " + minutes + ":" + seconds;
            }
            else
            {
                // todo go to end scence with no time
            }
        }
    }

    public static void startTimer()
    {
        timerOn = true;
    }

    public static void stopTimer()
    {
        timerOn = false;
    }
}
