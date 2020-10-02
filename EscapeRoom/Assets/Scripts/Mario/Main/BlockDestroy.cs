using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float zPos;
    float waiting = 0.10F;
    private int isTriggered;
    [SerializeField] public GameObject toDestroy;

    // Use this for initialization
    void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;
    }

    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            xPos = toDestroy.transform.position.x;
            yPos = toDestroy.transform.position.y;
            zPos = toDestroy.transform.position.z;
            toDestroy.transform.position = new Vector3(xPos, yPos + 0.1F, zPos);
            yield return new WaitForSeconds(waiting);
            toDestroy.transform.position = new Vector3(xPos, yPos - 4.0F, zPos);
            yield return new WaitForSeconds(waiting);
            toDestroy.transform.position = new Vector3(xPos, yPos + 0.1F, zPos);
            yield return new WaitForSeconds(waiting);
            toDestroy.transform.position = new Vector3(xPos, yPos - 4.0F, zPos + 2.0F);
            yield return new WaitForSeconds(0.25F);
            toDestroy.transform.GetComponent<Collider>().isTrigger = true;
            Destroy(gameObject);
        }
    }
}