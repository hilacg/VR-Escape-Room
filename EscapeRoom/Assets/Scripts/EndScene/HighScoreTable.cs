using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{
    [SerializeField] public Transform entryContainer;
    [SerializeField] public Transform entryTemplate;

    private void Awake()
    {
        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 20f;
        for (int i = 0; i < 10; i++)
        {
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform EntryRectTransform = entryTransform.GetComponent<RectTransform>();
            EntryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);

            int rank = i + 1 ;
            string rankString;
            switch (rank)
            {
                default:
                    rankString = rank + "TH"; break;

                case 1: rankString = "1ST"; break;
                case 2: rankString = "2ND"; break;
                case 3: rankString = "3RD"; break;
            }

            int score = Random.Range(6, 60);

            string name = "AAA";
            entryTransform.Find("PosText").GetComponent<Text>().text = rankString;
            entryTransform.Find("NameText").GetComponent<Text>().text = name;
            entryTransform.Find("ScoreText").GetComponent<Text>().text = score.ToString() + "MIN";
        }
    }
}
