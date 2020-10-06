using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattriesFound : MonoBehaviour, ClickAction
{
    [SerializeField] GameObject battaries;
    public void doAction()
    {
        // this.gameObject.SetActive(false);
        battaries.gameObject.SetActive(false);
        SecondRoomCheck.foundKey();
    }
}
