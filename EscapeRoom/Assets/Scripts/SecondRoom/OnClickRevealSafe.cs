﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickRevealSafe : MonoBehaviour
{
    [SerializeField]
    public GameObject poly;
    [SerializeField]
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnMouseDown()
    {
        this._anim.SetTrigger("RevealSafe");
       // _anim.SetTrigger("RevealSafe");
    }
}