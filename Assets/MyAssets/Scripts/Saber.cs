using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saber : MonoBehaviour {
    int score;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreText.text = score.ToString("D3");
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bot")
        {
            score++;
            scoreText.text = score.ToString("D3");
            //gets the attack bot parent
            AttackBot b = other.GetComponentInParent<AttackBot>();
            //calls the body and disables the collider.
            b.blowUp();


        }

    }
}
