using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterToOpenScreen : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        PlayerPrefs.SetInt("New", 100);
        Application.LoadLevel(0);
    }
}
