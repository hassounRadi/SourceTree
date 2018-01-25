using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements; // lldi3aye
public class UnityAdManager : MonoBehaviour {
    public static UnityAdManager instance;
    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);//ma btdmar 3l load aw unload
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowAd()
    {
        if (PlayerPrefs.HasKey("AdCount")) // exa add count mawjud
        {
            if (PlayerPrefs.GetInt("AdCount") == 3) //exa bysewe 0
            {
                //show add
                if (Advertisement.IsReady("rewardedVideo")) //eza ladvertissment jehez mesh ready menshaghela
                {
                    Advertisement.Show("rewardedVideo");
                }
                PlayerPrefs.SetInt("AdCount", 0); //mnrja3 mnsafro
            }
            else
            {
                //eza b3do ma bysewe 3
                PlayerPrefs.SetInt("AdCount", PlayerPrefs.GetInt("AdCount") + 1);//bzydo 1
            }
           
        }
        else
        {
            PlayerPrefs.SetInt("AdCount",0); //mnkhla2o eza mehs mawjud
            //2cKN45O4y1iomD0Qd4To389o4cxWiVwl6F7BKVFGWy2H93io8AaBJk-NLvv3PqpV3wgNPxexuhD1lwqt5O2O70
        }

    }
}
