using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class characterMove : MonoBehaviour {
    //public static bool moveforward;
    public float speed = 2F;
    private CharacterController controller;
    private Transform vrHead;
    [SerializeField] private Transform backUpCamera;
    private bool moveForword = false;
    //float startTime = -1;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        if (Camera.main != null && Camera.main.transform != null)
        {
            vrHead = Camera.main.transform;
        }
        else
        {
            vrHead = backUpCamera;
        }
        
    }

    void Update()
    {
        if(!(Input.GetAxis("Vertical") < 0.1 && Input.GetAxis("Vertical") > - 0.1) || !(Input.GetAxis("Horizontal") < 0.1 && Input.GetAxis("Horizontal") > -0.1)){ //Joystick in use
            Vector3 moveVector = vrHead.forward * speed;
            controller.Move(moveVector * Time.deltaTime);
        }
    }
}
