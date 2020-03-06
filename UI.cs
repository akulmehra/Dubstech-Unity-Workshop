using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    GameObject player;
    public Text scoreText;
   
    // Use this for initialization
	void Start () {
        player = GameObject.Find("Player");	
	}
	
	// Update is called once per frame
	void Update () {
        Player playerScript = player.GetComponent<Player>();
        int numberOfCoins = playerScript.returnCoins();

        scoreText.text = "Coins : " + numberOfCoins;
	}
}
