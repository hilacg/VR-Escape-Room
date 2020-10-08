using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressColor : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        Code.code += this.name;
        Debug.Log(this.name);
    }
}
