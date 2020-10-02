using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCoinBox : MonoBehaviour
{
    [SerializeField] public GameObject Coin;
    [SerializeField] public GameObject OpenBox;
    [SerializeField] public GameObject UnOpenBox;
    private float waiting = 0.10F;
    // Start is called before the first frame update
    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Coin.SetActive(true);
            float xPos = Coin.transform.position.x;
            float yPos = Coin.transform.position.y;
            float zPos = Coin.transform.position.z;
            Coin.transform.position = new Vector3(xPos, yPos + 0.5F, zPos);
            yield return new WaitForSeconds(waiting);
            Coin.transform.position = new Vector3(xPos, yPos + 1F, zPos);
            OpenBox.SetActive(true);
            UnOpenBox.SetActive(false);
            Destroy(UnOpenBox);
            Destroy(gameObject);
        }
    }
}
