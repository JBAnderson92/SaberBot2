using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapSelector : MonoBehaviour {

    public Image[] icons;
    public int currentID;


	// Use this for initialization
	void Start () {
        selectID(2);
	}
    public void selectID(int id)
    {
        currentID = (4 + id) % 4;
        for(int i = 0; i<4; i++)
        {
            icons[i].enabled = (i == currentID);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
