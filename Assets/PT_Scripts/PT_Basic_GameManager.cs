using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PT_Basic_GameManager : MonoBehaviour {

    public PT_2D_Map_Builder MapManager;
    public string[] levelsData;
    public int currentLevelIndex = 0;
    public float messageStayTime = 2f;

    public int maxLevelIndex;
    public int score;
    public int deaths;
private int pastscore;
    public Text scoreText;
    //public Text deathstext;
    public Text levelText;
    public Text winText;
    public Text startText;
    public GameObject lastpannel;

    private float messageEnds;

    // Use this for initialization
    void Start () {
        MapManager.rawMapData = levelsData[currentLevelIndex];
        MapManager.ReloadMap();
        messageEnds = Time.time + messageStayTime;
        pastscore = score;
    }
	
	// Update is called once per frame
	void Update () {
        if(messageEnds < Time.time && startText.gameObject.activeSelf)
        {
            startText.gameObject.SetActive(false);
        }

        if (Input.GetKeyUp("x"))
        {
            currentLevelIndex = 0;
            startText.gameObject.SetActive(true);
            messageEnds = Time.time + messageStayTime;
            MapManager.rawMapData = levelsData[currentLevelIndex];
            MapManager.ReloadMap();
            winText.gameObject.SetActive(false);
        }
        int tmpLevel = currentLevelIndex + 1;
        scoreText.text = "Score: " + score.ToString();
        //deathstext.text = "Died: " + deaths.ToString();
        levelText.text = "Level: " + tmpLevel.ToString();
        if (Input.GetKeyUp("n"))
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        if((currentLevelIndex + 1) < levelsData.Length)
        {
            currentLevelIndex++;
            print("currentlevelIndex: " + currentLevelIndex.ToString());
            MapManager.rawMapData = levelsData[currentLevelIndex];
            MapManager.ReloadMap();
            pastscore = score;
        }
        else
        {
            lastpannel.SetActive(true);
        }
    }
    public void RestartLevel()
    {
        MapManager.ReloadMap();
        score = pastscore;
          scoreText.text = "Score: " + score.ToString();

    }
}
