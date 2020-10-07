using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickHighScore : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        PlayerPrefs.SetInt("New", 0);
        Application.LoadLevel(Scences.EndScreen);
    }
}
