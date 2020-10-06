using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetFloat("Time", TimerDisplay.globaltime);
        Application.LoadLevel(5);
    }
}
