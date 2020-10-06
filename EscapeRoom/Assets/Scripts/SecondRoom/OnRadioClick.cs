using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRadioClick : MonoBehaviour, ClickAction
{
    [SerializeField] public GameObject Pannel;
    public void doAction()
    {
        if (SecondRoomCheck.isFoundTheKey())
        {
            Pannel.SetActive(true);
        }
    }
}
