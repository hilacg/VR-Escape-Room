using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class standOnShow : MonoBehaviour
{
    [SerializeField] public GameObject toShow;

    public void OnTriggerEnter()
    {
        toShow.SetActive(true);
    }

    public void OnTriggerExit()
    {
        toShow.SetActive(false);
    }
}
