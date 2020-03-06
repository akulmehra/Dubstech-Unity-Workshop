using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    GameObject player;

    // Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player") {
            if (gameObject.tag == "Coin") {
                // Whatever happens once the player collects the coin
                Player playerScript = collision.gameObject.GetComponent<Player>();
                playerScript.addCoins();
            }

            Destroy(gameObject);
        }
    }
}
