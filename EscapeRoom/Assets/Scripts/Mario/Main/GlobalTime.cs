using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalTime : MonoBehaviour
{
    [SerializeField] public GameObject TimeDisplay;
    public static float TimePassed;

    void Update()
    {
        TimePassed = Time.timeSinceLevelLoad;

        TimeDisplay.GetComponent<UnityEngine.UI.Text>().text = "Time: " + TimePassed;
    }
}
