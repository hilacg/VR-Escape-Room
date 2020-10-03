using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAction : MonoBehaviour, ClickAction
{
    public void doAction()
    {
        print(transform.name);
    }
}
