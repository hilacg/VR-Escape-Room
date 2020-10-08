using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRoomDoor : MonoBehaviour, ClickAction
{

    [SerializeField]
    private Animator animator;
    public void doAction()
    {
        if (SecondRoomCheck.IsKeyFound())
        {
            animator.SetTrigger("OpenDoor");
        }
    }
}

