using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVOnOff : MonoBehaviour, ClickAction
{
    private bool isOn;
    [SerializeField] public GameObject TV;
    public void doAction()
    {
        isOn = (isOn == true) ? false : true;
        TV.gameObject.SetActive(isOn);
    }

    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
    }
}
