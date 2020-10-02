using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomMove : MonoBehaviour
{
    private float rightEdge;
    private float leftEdge;
    private int Direction = 1;
    [SerializeField] public GameObject MainPlayer;
    [SerializeField] public GameObject BorderObjectLeft;
    [SerializeField] public GameObject BorderObjectRight;
    void Start()
    {   
        rightEdge = BorderObjectRight.transform.position.x - 1f;
        leftEdge = BorderObjectLeft.transform.position.x + 1f;
    }

    void Update()
    {
        if(Direction == 1)
        {
            this.transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
        }
        if (this.transform.position.x >= rightEdge)
        {
            Direction = 2;
            this.transform.rotation = new UnityEngine.Quaternion(this.transform.rotation.x, -this.transform.rotation.y, this.transform.rotation.z, this.transform.rotation.w);
        }

        if (Direction == 2)
        {
            this.transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
        }
        if (this.transform.position.x <= leftEdge)
        {
            Direction = 1;
            this.transform.rotation = new UnityEngine.Quaternion(this.transform.rotation.x, -this.transform.rotation.y, this.transform.rotation.z, this.transform.rotation.w);
        }
    }
}
