using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTryOpenKeyHole : MonoBehaviour, ClickAction
{
    [SerializeField] public GameObject CodeLock;
    [SerializeField] GameObject canvasKey;
    public void doAction()
    {
        if (FirstRoomCheck.isFoundTheKey())
        {
            CodeLock.SetActive(true);
            canvasKey.gameObject.SetActive(false);
        }
    }
}
