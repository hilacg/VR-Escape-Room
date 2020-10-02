using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorScript : MonoBehaviour, ClickAction
{ 
    public void doAction()
    {
        // this.GetComponent<Animator>().enabled = true;

        this.GetComponent<Animator>().SetBool("open", true);
        //this
    }
}
