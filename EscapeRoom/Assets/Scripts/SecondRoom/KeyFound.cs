using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFound : MonoBehaviour
{
    [SerializeField] 
    public GameObject Key;

    void OnMouseDown()
    {
        Key.SetActive(false);
        SecondRoomCheck.foundKey();
        Debug.Log("Foud key");
    }
}
