using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    bool gameOver;
	// Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);//ma bykasera l lball bs yballesh
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);//ykasera eza kenet mawjude
        }
    }
	void Start () {
        gameOver = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart() {
        UiManager.instance.GameStart();
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().StartSpawningPipes();
    }

    public void GameOver()
    {
        gameOver = false;
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().StopSpawningPipes();
        ScoreManager.instance.StopScore();
        UiManager.instance.GameOver();
        UnityAdManager.instance.ShowAd();
    }
}
