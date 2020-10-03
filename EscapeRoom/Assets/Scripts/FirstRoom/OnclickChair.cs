using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnclickChair : MonoBehaviour, ClickAction
{
    [SerializeField] public GameObject chair;
    [SerializeField] public float xRotation;
    [SerializeField] public float yRotation;
    [SerializeField] public float zRotation;


    private Transform chairTransform;
    void Start()
    {
        chairTransform = chair.gameObject.transform;
    }

    public void doAction()
    {
        chairTransform.Rotate(xRotation, yRotation, zRotation, Space.World);
        xRotation *= -1;
        yRotation *= -1;
        zRotation *= -1;
    }
}
