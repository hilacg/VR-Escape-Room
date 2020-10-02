using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        Code.code = Code.code + "1";
    }
}
