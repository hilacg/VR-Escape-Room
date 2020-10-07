using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMario : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        PlayerPrefs.SetFloat("startTime", TimerDisplay.startTime);
        Cursor.lockState = CursorLockMode.Confined;
        Application.LoadLevel(Scences.SecondRoom);
    }

}
