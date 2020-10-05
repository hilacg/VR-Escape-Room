using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartClick : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        Application.LoadLevel(1);
    }
}
