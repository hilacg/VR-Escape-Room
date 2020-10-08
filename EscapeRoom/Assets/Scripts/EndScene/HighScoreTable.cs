using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{
    [SerializeField] public Transform entryContainer;
    [SerializeField] public Transform entryTemplate;
    private List<Transform> highScoreEntryTransformList;
    private List<HighScoreEntry> highScoreEntryList;

    private void Start()
    {
        entryTemplate.gameObject.SetActive(false);
            
        string jsonString = PlayerPrefs.GetString("HighScoreTable");
        HighScores listHighScores = JsonUtility.FromJson<HighScores>(jsonString);

        if(listHighScores == null)
        {
            Debug.Log("add defaults");
            highScoreEntryList = new List<HighScoreEntry>()
            {
               new HighScoreEntry { minutes = 30, seconds = 1000},
               new HighScoreEntry { minutes = 30, seconds = 0000},
               new HighScoreEntry { minutes = 30, seconds = 2000},
               new HighScoreEntry { minutes = 30, seconds = 2500},
               new HighScoreEntry { minutes = 30, seconds = 1000},
               new HighScoreEntry { minutes = 30, seconds = 5900},
               new HighScoreEntry { minutes = 30, seconds = 1000},
               new HighScoreEntry { minutes = 30, seconds = 1000},
               new HighScoreEntry { minutes = 30, seconds = 1000},
               new HighScoreEntry { minutes = 30, seconds = 1000}
            };
            HighScores defaultHighScores = new HighScores { highScoreEntryList = highScoreEntryList };
            SortList(defaultHighScores);
            string json = JsonUtility.ToJson(defaultHighScores);
            PlayerPrefs.SetString("HighScoreTable", json);
            PlayerPrefs.Save();
            jsonString = PlayerPrefs.GetString("HighScoreTable");
            listHighScores = JsonUtility.FromJson<HighScores>(jsonString);
        }

        int isNew = PlayerPrefs.GetInt("New");
        float playerTime = PlayerPrefs.GetFloat("EndTime");
        int minutes = ((int)playerTime)/60;
        int seconds = (int)((playerTime % 60)*100);         
        if (minutes < 60 && isNew > 0)
        {
            AddHighScoreEntry(minutes, seconds);
            PlayerPrefs.SetInt("New", 0);
            jsonString = PlayerPrefs.GetString("HighScoreTable");
            listHighScores = JsonUtility.FromJson<HighScores>(jsonString);
        }

        SortList(listHighScores);
        
        highScoreEntryTransformList = new List<Transform>();
        foreach (HighScoreEntry highScoreEntry in listHighScores.highScoreEntryList)
        {
            CreateHighScoreEntryTransform(highScoreEntry, entryContainer, highScoreEntryTransformList);
        }
    }

     private void SortList(HighScores listHighScores)
    {
        for (int i = 0; i < listHighScores.highScoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < listHighScores.highScoreEntryList.Count; j++)
            {
                if (listHighScores.highScoreEntryList[j].minutes == listHighScores.highScoreEntryList[i].minutes)
                {
                    if (listHighScores.highScoreEntryList[j].seconds < listHighScores.highScoreEntryList[i].seconds)
                    {
                        HighScoreEntry tmp = listHighScores.highScoreEntryList[i];
                        listHighScores.highScoreEntryList[i] = listHighScores.highScoreEntryList[j];
                        listHighScores.highScoreEntryList[j] = tmp;
                    }
                }
                else if (listHighScores.highScoreEntryList[j].minutes < listHighScores.highScoreEntryList[i].minutes)
                {
                    HighScoreEntry tmp = listHighScores.highScoreEntryList[i];
                    listHighScores.highScoreEntryList[i] = listHighScores.highScoreEntryList[j];
                    listHighScores.highScoreEntryList[j] = tmp;
                }
            }
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

        int score = highScoreEntry.minutes;
        int scoreseconds = highScoreEntry.seconds;
        
        entryTransform.Find("PosText").GetComponent<Text>().text = rankString;
        string minutes = (score).ToString();
        string seconds = scoreseconds.ToString();
        entryTransform.Find("ScoreText").GetComponent<Text>().text = minutes + ":" + seconds + " MIN";

        entryTransform.Find("BackGround").gameObject.SetActive(rank % 2 == 1);

        if( rank == 1)
        {
            entryTransform.Find("PosText").GetComponent<Text>().color = Color.yellow;
            entryTransform.Find("ScoreText").GetComponent<Text>().color = Color.yellow;
        }
        transformList.Add(entryTransform);
    }

    private void AddHighScoreEntry(int minutes, int seconds)
    {
        HighScoreEntry highScoreEntry = new HighScoreEntry { minutes = minutes , seconds = seconds};

        string jsonString = PlayerPrefs.GetString("HighScoreTable");
        HighScores HighScores = JsonUtility.FromJson<HighScores>(jsonString);
        int max = findMax(HighScores.highScoreEntryList);
        if (HighScores.highScoreEntryList[max].minutes == highScoreEntry.minutes)
        {
            if (HighScores.highScoreEntryList[max].seconds > highScoreEntry.seconds)
            {
                HighScores.highScoreEntryList[max] = highScoreEntry;
            }
        }
        else if (HighScores.highScoreEntryList[max].minutes > highScoreEntry.minutes)
        {
            HighScores.highScoreEntryList[max] = highScoreEntry;
        }

        string json = JsonUtility.ToJson(HighScores);
        PlayerPrefs.SetString("HighScoreTable", json);
        PlayerPrefs.Save();
    }

    private int findMax(List<HighScoreEntry> highScoreEntryList)
    {
        int max = 0;
        for (int i=1; i<10;i++)
        {
            if (highScoreEntryList[max].minutes == highScoreEntryList[i].minutes)
            {
                if (highScoreEntryList[max].seconds < highScoreEntryList[i].seconds)
                {
                    max = i;
                }
            } else if (highScoreEntryList[max].minutes < highScoreEntryList[i].minutes)
            {
                max = i;
            }


        }
        return max;
    }

    private class HighScores
    {
        public List<HighScoreEntry> highScoreEntryList;

    }

    [System.Serializable]
    private class HighScoreEntry
    {
        public int minutes;
        public int seconds;
    }
}

