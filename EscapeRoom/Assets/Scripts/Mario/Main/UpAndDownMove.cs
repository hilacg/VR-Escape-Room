using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDownMove : MonoBehaviour
{
    // Update is called once per frame
    float factor = -0.2f;
    int flag = 1;

    void Update()
    {
        StartCoroutine(doUpAndDown());
    }

    private IEnumerator doUpAndDown()
    {
        if(flag == 1)
        {
            flag = 0;
            factor *= -1f;
            transform.position = new Vector3(transform.position.x, transform.position.y + factor, transform.position.z);
            yield return new WaitForSeconds(0.1f);
            flag = 1;
        }

    }
}
