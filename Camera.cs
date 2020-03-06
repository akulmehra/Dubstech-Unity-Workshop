using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    GameObject player;

    // Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 updatedPosition = new Vector3(player.transform.position.x, player.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.position = updatedPosition;

	}
}
