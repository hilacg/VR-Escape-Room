using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{
    [SerializeField] public Transform entryContainer;
    [SerializeField] public Transform entryTemplate;
    private List<Transform> highScoreEntryTransformList;

    private void Awake()
    {
        entryTemplate.gameObject.SetActive(false);

        // AddHighScoreEntry(40, "cmk");

        string jsonString = PlayerPrefs.GetString("HighScoreTable");
        HighScores HighScores = JsonUtility.FromJson<HighScores>(jsonString);

        for (int i = 0; i < HighScores.highScoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < HighScores.highScoreEntryList.Count; j++)
            {
                if(HighScores.highScoreEntryList[j].score < HighScores.highScoreEntryList[i].score)
                {
                    HighScoreEntry tmp = HighScores.highScoreEntryList[i];
                    HighScores.highScoreEntryList[i] = HighScores.highScoreEntryList[j];
                    HighScores.highScoreEntryList[j] = tmp;
                }
            }
        }
        highScoreEntryTransformList = new List<Transform>();
        foreach (HighScoreEntry highScoreEntry in HighScores.highScoreEntryList)
        {
            CreateHighScoreEntryTransform(highScoreEntry, entryContainer, highScoreEntryTransformList);
        }
    }

    private void CreateHighScoreEntryTransform(HighScoreEntry highScoreEntry, Transform container, List<Transform> transformList)
    {
        float templateHeight = 20f;
        Transform entryTransform = Instantiate(entryTemplate, container);
        RectTransform EntryRectTransform = entryTransform.GetComponent<RectTransform>();
        EntryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
        entryTransform.gameObject.SetActive(true);

        int rank = transformList.Count +1;
        string rankString;
        switch (rank)
        {
            default:
                rankString = rank + "TH"; break;

            case 1: rankString = "1ST"; break;
            case 2: rankString = "2ND"; break;
            case 3: rankString = "3RD"; break;
        }

        int score = highScoreEntry.score;
        string name = highScoreEntry.name;

        entryTransform.Find("PosText").GetComponent<Text>().text = rankString;
        entryTransform.Find("NameText").GetComponent<Text>().text = name;
        entryTransform.Find("ScoreText").GetComponent<Text>().text = score.ToString() + "MIN";

        entryTransform.Find("BackGround").gameObject.SetActive(rank % 2 == 1);

        if( rank == 1)
        {
            entryTransform.Find("PosText").GetComponent<Text>().color = Color.yellow;
            entryTransform.Find("NameText").GetComponent<Text>().color = Color.yellow;
            entryTransform.Find("ScoreText").GetComponent<Text>().color = Color.yellow;
        }
        transformList.Add(entryTransform);
    }

    private void AddHighScoreEntry(int score, string name)
    {
        HighScoreEntry highScoreEntry = new HighScoreEntry { score = score, name = name };

        string jsonString = PlayerPrefs.GetString("HighScoreTable");
        HighScores HighScores = JsonUtility.FromJson<HighScores>(jsonString);

        if(HighScores.highScoreEntryList[9].score > highScoreEntry.score)
        {
            HighScores.highScoreEntryList[9] = highScoreEntry;
        }
        // HighScores.highScoreEntryList.Add(highScoreEntry);

        string json = JsonUtility.ToJson(HighScores);
        PlayerPrefs.SetString("HighScoreTable", json);
        PlayerPrefs.Save();
    }

    private class HighScores
    {
        public List<HighScoreEntry> highScoreEntryList;

    }

    [System.Serializable]
    private class HighScoreEntry
    {
        public int score;
        public string name;

    }
}