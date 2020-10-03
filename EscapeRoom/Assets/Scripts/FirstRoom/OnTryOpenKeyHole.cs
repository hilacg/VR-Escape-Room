using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTryOpenKeyHole : MonoBehaviour, ClickAction
{
    [SerializeField] public GameObject CodeLock;
    public void doAction()
    {
        if (FirstRoomCheck.isFoundTheKey())
        {
            CodeLock.SetActive(true);
        }
    }
}
