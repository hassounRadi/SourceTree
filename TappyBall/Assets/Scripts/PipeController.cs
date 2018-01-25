using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour {
    public float speed;//ser3et lpipe
    public float upDownSpeed; // ser3et lpipe bl teskir wl fateh
    Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();//Access to rigibbody 2d
        MovePipe();
        InvokeRepeating("SwitchUpDownSpeed", 0.1f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void SwitchUpDownSpeed()
    {
        upDownSpeed = -upDownSpeed;
        rb.velocity = new Vector2(speed,upDownSpeed);
    }
    void MovePipe()
    {
        rb.velocity = new Vector2(-speed, upDownSpeed); // mnamshiha 3la l x l wra 3l negative w btnzal w btotla3 hasab l upDown
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PipeRemover")//eza hayde lpipe li 3m temshe lma khtfet da2aret bl rag pipe remover lezem tetkassar 
        {
            Destroy(gameObject);
        }
    }
}
