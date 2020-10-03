using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerCloseDoor : MonoBehaviour
{
    [SerializeField] public GameObject Door;
    private bool closed = false; 

    private Animator animator;
    private void Start()
    {
        animator = Door.GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider col)
    {
        if (!closed)
        {
            animator.Play("DoorClose");
            closed = true;
        }
    }
}
