using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToEndScreen : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Application.LoadLevel(2);
    }
}
