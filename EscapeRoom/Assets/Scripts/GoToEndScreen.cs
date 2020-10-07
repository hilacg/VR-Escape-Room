using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToEndScreen : MonoBehaviour
{
    void OnTriggerEnter()
    {
        PlayerPrefs.SetFloat("EndTime", TimerDisplay.globaltime);
        PlayerPrefs.SetInt("New", 100);
        Application.LoadLevel(5);
    }
}
