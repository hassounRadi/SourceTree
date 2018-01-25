using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    Rigidbody2D rb;
    public float upForce;
    bool started;
    bool gameOver;
    public float rotation;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();//Access to rigibbody 2d
        started = false;//tkun b3da mehs mblshe ltabe tnot
        gameOver = false;//gameover b3da false
	}
	
	// Update is called once per frame
	void Update () {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))//eza kabaset ltouch awal ma ballesh le3eb
            {
                started = true; // khalli lgame tballesh
                rb.isKinematic = false;//b3te acces men lrigidbody 3l iskanamtic w b3mla false ltsir ltabe tou2a3
                GameManager.instance.GameStart();
            }
        }
        else if(started && !gameOver)
        {
            transform.Rotate(0, 0, rotation);
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero; //nsaffer ser3et lball
                rb.AddForce(new Vector2(0, upForce));//khalle ltabe temshe betejeh l y 
            }
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        gameOver = true;
        GameManager.instance.GameOver();
        GetComponent<Animator>().Play("ball");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Pipe" && !gameOver)//eza fetet lball bl pipe
        {
            gameOver = true;
            GameManager.instance.GameOver();//y3yet l gameover

            GetComponent<Animator>().Play("ball");//t2leb lball ll ball2
        }
        if (col.gameObject.tag == "ScoreChecker" && !gameOver)//eza mer2et lball bl Score checker li ben ltnen pipe wl gameover b3da false
        {
            ScoreManager.instance.IncrementScore();
        }
    }
}
