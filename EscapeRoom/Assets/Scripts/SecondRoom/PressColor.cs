using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressColor : MonoBehaviour
{
    void OnMouseDown()
    {
        Code.code += this.name;
        Debug.Log(this.name);
    }
}
