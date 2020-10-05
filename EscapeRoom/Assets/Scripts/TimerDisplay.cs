using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour
{
    public static float startTime;
    public static float globaltime;
    private static bool timerOn = false;
    [SerializeField] public Text timerText;


    void Start()
    {
        float getTime = PlayerPrefs.GetFloat("lkaugsdfk");
        Debug.Log(getTime);
        if (getTime <= 0)
        {
            startTime = Time.time;
        }
        // Debug.Log(startTime);
    }

    void Update()
    {
        if (timerOn)
        {
            globaltime = Time.time - startTime;

            if (globaltime < 60)
            {
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
        timerOn = true;
    }
}
