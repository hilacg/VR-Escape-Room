using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        transform.position = new Vector3(0, -1000, 0);
        GlobalCoins.CoinCount += 1;
        GlobalScore.ScoreCount += 1;
    }
}
