using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScore : MonoBehaviour
{
    [SerializeField] public GameObject ScoreDisplay;
    public static int ScoreCount;
    public int InternalScore;

    void Update()
    {
        InternalScore = ScoreCount;
        ScoreDisplay.GetComponent<UnityEngine.UI.Text>().text = "Score: " + ScoreCount;
    }
}
   