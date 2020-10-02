using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] public GameObject MainPlayer;
    [SerializeField] public AudioSource audio;

    public IEnumerator OnTriggerEnter(Collider col)
    {
        audio.Play();
        MainPlayer.SetActive(false);
        yield return new WaitForSeconds(1);
        Application.LoadLevel(1);
        GlobalCoins.CoinCount = 0;
        GlobalScore.ScoreCount = 0;
        GlobalTime.TimePassed = 0;
    }
}
