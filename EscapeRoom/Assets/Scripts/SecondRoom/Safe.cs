﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour,ClickAction
{
    [SerializeField] 
    public GameObject safe;
    [SerializeField]
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void doAction()
    {
            _anim.SetTrigger("OpenSafe");

    }
}