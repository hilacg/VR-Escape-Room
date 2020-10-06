﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRoomDoor : MonoBehaviour
{

    [SerializeField]
    private Animator animator;
    void OnMouseDown()
    {
        if (SecondRoomCheck.IsKeyFound())
        {
            animator.SetTrigger("OpenDoor");
        }
    }
}

