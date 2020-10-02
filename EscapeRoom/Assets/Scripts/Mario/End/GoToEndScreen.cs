using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToEndScreen : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FinalTime.finalTime = Time.timeSinceLevelLoad;
        Application.LoadLevel(2);
    }
}
