using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    int health = 20;
    public Text healthText;

	// Use this for initialization
	void Start () {
        health = 20;
        healthText.text = health.ToString("D2");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bot")
        {
            health--;
            healthText.text = health.ToString("D2"); 

            if(health == 0)
            {
                Time.timeScale = 0;
            }
            //gets the attack bot parent
            AttackBot b = other.GetComponentInParent<AttackBot>();
            //calls the body and disables the collider.
            b.blowUp();


        }

    }
}
