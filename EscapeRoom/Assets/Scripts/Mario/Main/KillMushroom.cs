using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMushroom : MonoBehaviour
{
    [SerializeField] public GameObject Mushroom;

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider col)
    {
        BoxCollider box = (BoxCollider) this.GetComponent("BoxCollider");
        box.enabled = false;
        Mushroom.SetActive(false);
        GlobalScore.ScoreCount += 5;
    }
}
