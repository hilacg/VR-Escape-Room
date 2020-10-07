using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterToOpenScreen : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            PlayerPrefs.SetInt("New", 100);
            Application.LoadLevel(Scences.OpenScreen);
        }
    }
}
