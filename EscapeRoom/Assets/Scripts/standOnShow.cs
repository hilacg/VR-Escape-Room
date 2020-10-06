using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class standOnShow : MonoBehaviour
{
    [SerializeField] public GameObject toShow;

    void OnTriggerEnter()
    {
        toShow.SetActive(true);
    }

    void OnTriggerExit()
    {
        toShow.SetActive(false);
    }
}
