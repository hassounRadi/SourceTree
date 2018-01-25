using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour {
    public static ScoreManager instance;
    public int score;
    //public static int nb;
    //public Text fatimaText;
   // public AudioSource gameBirthdayMusic;
    // Use this for initialization

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }    
	void Start () {
        //gameBirthdayMusic.Stop();
        score = 0;
        //nb = 0;
        //PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.SetInt("Score", 0);//hot 2ymet lscore ljdid b localsotrage esma score
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncrementScore()
    {
        score++;
        //nb++;
        //if (nb == 1)
        //{
        //    fatimaText.text = "H";
        //}
        //else if (nb == 2)
        //{
        //    fatimaText.text = "HA";
        //}
        //else if (nb == 3)
        //{
        //    fatimaText.text = "HAP";
        //}
        //else if (nb == 4)
        //{
        //    fatimaText.text = "HAPP";
        //}
        //else if (nb == 5)
        //{
        //    fatimaText.text = "HAPPY";
        //}
        //else if (nb == 6)
        //{
        //    fatimaText.text = "B";
        //}
        //else if (nb == 7)
        //{
        //    fatimaText.text = "BI";
        //}
        //else if (nb == 8)
        //{
        //    fatimaText.text = "BIR";
        //}
        //else if (nb == 9)
        //{
        //    fatimaText.text = "BIRT";
        //}
        //else if (nb == 10)
        //{
        //    fatimaText.text = "BIRTH";
        //}
        //else if (nb == 11)
        //{
        //    fatimaText.text = "BIRTHD";
        //}
        //else if (nb == 12)
        //{
        //    fatimaText.text = "BIRTHDA";
        //}
        //else if (nb == 13)
        //{
        //    fatimaText.text = "BIRTHDAY";
        //}
        //else if (nb == 14)
        //{
        //    fatimaText.text = "F";
        //}
        //else if (nb == 15)
        //{
        //    fatimaText.text = "FA";
        //}
        //else if (nb == 16)
        //{
        //    fatimaText.text = "FAT";
        //}
        //else if (nb == 17)
        //{
        //    fatimaText.text = "FATO";
        //}
        //else if (nb == 18)
        //{
        //    fatimaText.text = "FATOU";
        //}
        //else if (nb == 19)
        //{
        //    fatimaText.text = "FATOUM";
        //}
        //else if (nb == 20)
        //{
        //    fatimaText.text = "FATOUMA";
        //}
        //else if (nb == 21)
        //{
        //    fatimaText.text = "I";
        //}
        //else if (nb == 22)
        //{
        //    fatimaText.text = "I W";
        //}
        //else if (nb == 23)
        //{
        //    fatimaText.text = "I WI";
        //}
        //else if (nb == 24)
        //{
        //    fatimaText.text = "I WIS";
        //}
        //else if (nb == 25)
        //{
        //    fatimaText.text = "I WISH";
        //}
        //else if (nb == 26)
        //{
        //    fatimaText.text = "I WISH Y";
        //}
        //else if (nb == 27)
        //{
        //    fatimaText.text = "I WISH YO";
        //}
        //else if (nb == 28)
        //{
        //    fatimaText.text = "I WISH YOU";
        //}
        //else if (nb == 29)
        //{
        //    fatimaText.text = "A";
        //}
        //else if (nb == 30)
        //{
        //    fatimaText.text = "AL";
        //}
        //else if (nb == 31)
        //{
        //    fatimaText.text = "ALL";
        //}
        //else if (nb == 32)
        //{
        //    fatimaText.text = "ALL T";
        //}
        //else if (nb == 33)
        //{
        //    fatimaText.text = "ALL TH";
        //}
        //else if (nb == 34)
        //{
        //    fatimaText.text = "ALL THE";
        //}
        //else if (nb == 35)
        //{
        //    fatimaText.text = "ALL THE B";
        //}
        //else if (nb == 36)
        //{
        //    fatimaText.text = "ALL THE BE";
        //}
        //else if (nb == 37)
        //{
        //    fatimaText.text = "ALL THE BES";
        //}
        //else if (nb == 38)
        //{
        //    fatimaText.text = "ALL THE BEST";
        //}
        //else if (nb == 39)
        //{
        //    fatimaText.text = "A";
        //}
        //else if (nb == 40)
        //{
        //    fatimaText.text = "AN";
        //}
        //else if (nb == 41)
        //{
        //    fatimaText.text = "AND";
        //}
        //else if (nb == 42)
        //{
        //    fatimaText.text = "AND T";
        //}
        //else if (nb == 43)
        //{
        //    fatimaText.text = "AND TH";
        //}
        //else if (nb == 44)
        //{
        //    fatimaText.text = "AND THE";
        //}
        //else if (nb == 45)
        //{
        //    fatimaText.text = "S";
        //}
        //else if (nb == 46)
        //{
        //    fatimaText.text = "SU";
        //}
        //else if (nb == 47)
        //{
        //    fatimaText.text = "SUC";
        //}
        //else if (nb == 48)
        //{
        //    fatimaText.text = "SUCC";
        //}
        //else if (nb == 49)
        //{
        //    fatimaText.text = "SUCCE";
        //}
        //else if (nb == 50)
        //{
        //    fatimaText.text = "SUCCESS";
        //}
        //else if (nb == 51)
        //{
        //    fatimaText.text = "I";
        //}
        //else if (nb == 52)
        //{
        //    fatimaText.text = "IN";
        //}
        //else if (nb == 53)
        //{
        //    fatimaText.text = "IN L";
        //}
        //else if (nb == 54)
        //{
        //    fatimaText.text = "IN LT";
        //}
        //else if (nb == 55)
        //{
        //    fatimaText.text = "IN LT I";
        //}
        //else if (nb == 56)
        //{
        //    fatimaText.text = "IN LT IN";
        //}
        //else if (nb == 57)
        //{
        //    fatimaText.text = "IN LT INF";
        //}
        //else if (nb == 58)
        //{
        //    fatimaText.text = "IN LT INFO";
        //}
        //else if (nb == 59)
        //{
        //    fatimaText.text = "2";
        //}
        //else if (nb == 60)
        //{
        //    fatimaText.text = "20";
        //}
        //else if (nb == 61)
        //{
        //    fatimaText.text = "20 Y";
        //}
        //else if (nb == 62)
        //{
        //    fatimaText.text = "20 YE";
        //}
        //else if (nb == 63)
        //{
        //    fatimaText.text = "20 YEA";
        //}
        //else if (nb == 64)
        //{
        //    fatimaText.text = "20 YEAR";
        //}
        //else if (nb == 65)
        //{
        //    fatimaText.text = "20 YEARS";
        //}
        //else if (nb == 66)
        //{
        //    fatimaText.text = "*20 YEARS*";
        //}
        //else if (nb == 67)
        //{
        //    fatimaText.text = "A";
        //}
        //else if (nb == 68)
        //{
        //    fatimaText.text = "AN";
        //}
        //else if (nb == 69)
        //{
        //    fatimaText.text = "AND";
        //}
        //else if (nb == 70)
        //{
        //    fatimaText.text = "AND Y";
        //}
        //else if (nb == 71)
        //{
        //    fatimaText.text = "AND YO";
        //}
        //else if (nb == 72)
        //{
        //    fatimaText.text = "AND YOU";
        //}
        //else if (nb == 73)
        //{
        //    fatimaText.text = "AND YOU W";
        //}
        //else if (nb == 74)
        //{
        //    fatimaText.text = "AND YOU WI";
        //}
        //else if (nb == 75)
        //{
        //    fatimaText.text = "AND YOU WIL";
        //}
        //else if (nb == 76)
        //{
        //    fatimaText.text = "AND YOU WILL";
        //}
        //else if (nb == 77)
        //{
        //    fatimaText.text = "S";
        //}
        //else if (nb == 78)
        //{
        //    fatimaText.text = "ST";
        //}
        //else if (nb == 79)
        //{
        //    fatimaText.text = "STA";
        //}
        //else if (nb == 80)
        //{
        //    fatimaText.text = "STAY";
        //}
        //else if (nb == 81)
        //{
        //    fatimaText.text = "STAY A";
        //}
        //else if (nb == 82)
        //{
        //    fatimaText.text = "STAY A C";
        //}
        //else if (nb == 83)
        //{
        //    fatimaText.text = "STAY A CH";
        //}
        //else if (nb == 84)
        //{
        //    fatimaText.text = "STAY A CHI";
        //}
        //else if (nb == 85)
        //{
        //    fatimaText.text = "STAY A CHIL";
        //}
        //else if (nb == 86)
        //{
        //    fatimaText.text = "STAY A CHILD";
        //}
        //else if (nb == 87)
        //{
        //    fatimaText.text = "4";
        //}
        //else if (nb == 88)
        //{
        //    fatimaText.text = "4E";
        //}
        //else if (nb == 89)
        //{
        //    fatimaText.text = "4EV";
        //}
        //else if (nb == 90)
        //{
        //    fatimaText.text = "4EVE";
        //}
        //else if (nb == 91)
        //{
        //    fatimaText.text = "4EVER";
        //}
        //else if (nb == 92)
        //{
        //    fatimaText.text = "T";
        //}
        //else if (nb == 93)
        //{
        //    fatimaText.text = "TA";
        //}
        //else if (nb == 94)
        //{
        //    fatimaText.text = "TAT";
        //}
        //else if (nb == 95)
        //{
        //    fatimaText.text = "TATT";
        //}
        //else if (nb == 96)
        //{
        //    fatimaText.text = "TATTO";
        //}
        //else if (nb == 97)
        //{
        //    fatimaText.text = "TATTOU";
        //}
        //else if (nb == 98)
        //{
        //    fatimaText.text = "TATTOUM";
        //}
        //else if (nb == 99)
        //{
        //    fatimaText.text = "TATTOUMA";
        //}
        //else if (nb == 100)
        //{
        //    fatimaText.text = "*TATTOUMA*";
        //}
        //else if (nb == 101)
        //{
        //    fatimaText.text = "❤❤❤❤❤";
        //    UiManager.instance.gameStartMusic.Stop();
        //    gameBirthdayMusic.Play();
        //}
        //else if (nb == 102)
        //{
        //    nb = 0;
        //}
    }

    public void StopScore()
    {
        PlayerPrefs.SetInt("Score", score);//hot 2ymet lscore ljdid b localsotrage esma score
        if (PlayerPrefs.HasKey("HighScore"))//eza fi localstorage esma higsocre fiha 2yme
        {
            if (score > PlayerPrefs.GetInt("HighScore")) //eza lscore ljed akbar men lhighlsocre lmahaffaz
            {
                PlayerPrefs.SetInt("HighScore", score);//hot 2ymet lscore ljdid
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", score);//khla2 localstorage w hot 2ymet lscore ljdid
        }
    }
}
