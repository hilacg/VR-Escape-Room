using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyFind : MonoBehaviour, ClickAction
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject canvasKey;
    public void doAction()
    {
        this.gameObject.SetActive(false);
        key.gameObject.SetActive(false);
        canvasKey.gameObject.SetActive(true);
        FirstRoomCheck.foundKey();
    }
}
