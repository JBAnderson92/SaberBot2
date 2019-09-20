using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackBot : MonoBehaviour {

    public NavMeshAgent agent;
    public Rigidbody body;
    Transform player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //forces agent on the ground
        agent.transform.position = new Vector3(agent.transform.position.x, 0, agent.transform.position.y);
        
        //random spinning
        body.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
	}
	
	// Update is called once per frame
	void Update () {
        agent.nextPosition = new Vector3(body.position.x, 0, body.position.z);
        agent.SetDestination(player.position);
        //assume player is at  y=2
        body.AddForce(agent.desiredVelocity + Vector3.up * (2 - body.position.y));
		
	}
    public void blowUp()
    {
        body.GetComponent<Collider>().enabled = false;
        //makes him stop moving
        body.constraints = RigidbodyConstraints.FreezeAll;
        body.GetComponent<Renderer>().enabled = false;
        body.GetComponent<ParticleSystem>().Play();
        Destroy(gameObject, 2);
    }
}
