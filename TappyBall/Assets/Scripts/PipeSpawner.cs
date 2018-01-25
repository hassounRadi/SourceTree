using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {
    public float maxYpos; //maximuim y position
    public float SpawnTime;//ben aya interval manna n3mel psawn ll pipe
    public GameObject pipe;
	// Use this for initialization
	void Start () {
        //StartSpawningPipes();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void StartSpawningPipes()
    {
        InvokeRepeating("SpawnPipe", 0.2f, SpawnTime);
    }

    public void StopSpawningPipes()
    {
        CancelInvoke("SpawnPipe");
    }
    void SpawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-maxYpos, maxYpos),0), Quaternion.identity); // tdalla nfs l x bas y tetghayar ben l -max wl max wl z tdal 0 wl rotation ydal hasab ma m3rfo bl unity
    }
}
