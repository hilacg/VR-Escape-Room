using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        Code.code = Code.code + "2";
    }
}