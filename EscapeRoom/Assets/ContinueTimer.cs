using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueTimer : MonoBehaviour
{
    void Start()
    {
        TimerDisplay.startTime = PlayerPrefs.GetFloat("startTime");
    }
}
