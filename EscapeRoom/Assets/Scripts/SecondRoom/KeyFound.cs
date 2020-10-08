using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFound : MonoBehaviour, ClickAction
{
     [SerializeField] 
    public GameObject Key;
  
    public void doAction()
    {
        Key.SetActive(false);
        SecondRoomCheck.foundKey();
    }
}
