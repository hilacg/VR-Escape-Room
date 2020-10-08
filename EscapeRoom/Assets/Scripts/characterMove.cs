using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class characterMove : MonoBehaviour {
    //public static bool moveforward;
    public float speed = 2F;
    private CharacterController controller;
    /*[SerializeField]*/ private Transform vrHead;
    private bool moveForword = false;
    //float startTime = -1;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        vrHead = Camera.main.transform;
    }

    void Update()
    {
        if(!(Input.GetAxis("Vertical") < 0.1 && Input.GetAxis("Vertical") > - 0.1) || !(Input.GetAxis("Horizontal") < 0.1 && Input.GetAxis("Horizontal") > -0.1)){ //Joystick in use
            Vector3 moveVector = vrHead.forward * speed;
            controller.Move(moveVector * Time.deltaTime);
        }
    }
}
