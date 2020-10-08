using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorInAndOut : MonoBehaviour
{
    public void colorIn()
    {
        GetComponent<Material>().color = Color.green;
    }

    public void colorOut()
    {
        GetComponent<Material>().color = Color.white;
    }
}
