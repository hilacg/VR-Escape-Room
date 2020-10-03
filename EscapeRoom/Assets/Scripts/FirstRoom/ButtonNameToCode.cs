using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNameToCode : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        Code.code = Code.code + this.name;
    }
}