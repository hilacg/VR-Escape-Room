using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnclickChair : MonoBehaviour, ClickAction
{
    [SerializeField] float xRotation;
    [SerializeField] float yRotation;
    [SerializeField] float zRotation;

    [SerializeField] float xPosition;
    [SerializeField] float yPosition;
    [SerializeField] float zPosition;
    public void doAction()
    {
        print("check");
        transform.rotation = new Quaternion(xRotation, yRotation, zRotation , 0);
        transform.position = new Vector3(xPosition, yPosition, zPosition);
    }
}
