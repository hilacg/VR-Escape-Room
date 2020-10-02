using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTime : MonoBehaviour
{
    [SerializeField] public GameObject TimeDisplay;
    public static float finalTime;

    void Update() { 
            TimeDisplay.GetComponent<UnityEngine.UI.Text>().text = "Time: " + finalTime;
        }
}
