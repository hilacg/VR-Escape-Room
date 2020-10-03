using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyFind : MonoBehaviour, ClickAction
{
    [SerializeField] GameObject key;
    public void doAction()
    {
        this.gameObject.SetActive(false);
        key.gameObject.SetActive(false);
    }
}
