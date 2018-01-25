using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {
    public static UiManager instance;
    public Text scoreText;
    public Text highScoreText;
    //public Text tryAgainText;
    public GameObject gameOverPanel;
    public GameObject gameOverText;
    public GameObject startUi;
    public AudioSource gameOverMusic;
    public AudioSource gameStartMusic;
    // Use this for initialization

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
	void Start () {
        gameOverMusic.Stop();
        gameStartMusic.Play();
        //tryAgainText.text = "";
    }
	
	// Update is called once per frame
	public void Update () {
        scoreText.text = ScoreManager.instance.score.ToString();
    }

    public void GameStart()
    {
        startUi.SetActive(false);
        
    }
    public void GameOver()
    {
        gameStartMusic.Stop();
        gameOverMusic.Play();
        //ScoreManager.instance.gameBirthdayMusic.Stop();
        gameOverText.SetActive(true);
        highScoreText.text ="HIGH SCORE: " + PlayerPrefs.GetInt("HighScore");
        //tryAgainText.text = "Try Again Fatouma :p";
        gameOverPanel.SetActive(true);

    }

    public void Replay()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
