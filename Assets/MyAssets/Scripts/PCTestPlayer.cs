using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCTestPlayer : MonoBehaviour {

    public MiniMapSelector teleportSelector;
    public Transform[] tps;
     
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            teleportSelector.selectID(teleportSelector.currentID + 2);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            teleportSelector.selectID(teleportSelector.currentID - 2);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            teleportSelector.selectID(teleportSelector.currentID + 1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            teleportSelector.selectID(teleportSelector.currentID - 1);
        }
        if (Input.GetButtonDown("Jump"))
        {
            transform.parent.position = tps[teleportSelector.currentID].position;
            transform.parent.rotation = tps[teleportSelector.currentID].rotation;
        }

    }
}
