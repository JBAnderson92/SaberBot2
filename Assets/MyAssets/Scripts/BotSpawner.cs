using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotSpawner : MonoBehaviour {
    public GameObject botPrefab;
    GameObject player;
    float nextSpawnTime;
    float waitTime;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        waitTime = Random.Range(2.0f, 4.0f);
        nextSpawnTime = Time.time + waitTime;
		
	}
    bool canSeePlayer()
    {
        RaycastHit hit;
        if (Physics.Linecast(transform.position, player.transform.position, out hit))
        {
            if (hit.collider.tag == "Wall")
            {
                return false;
            }
        }
        return true;



    }
	
	// Update is called once per frame
	void Update () {
        if(canSeePlayer() && Time.time > nextSpawnTime)
        {
            Instantiate(botPrefab, transform.position, Quaternion.identity);
            nextSpawnTime = Time.time + waitTime;
        }
		
	}
}
