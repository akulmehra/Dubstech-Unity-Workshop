using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public float moveSpeed;
    public float minDistance;
    GameObject player;
    Rigidbody2D rb;

    // Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {

        // checks if our player is within the minimum distance
        if (player != null)
        {
            if (Vector2.Distance(player.transform.position,
                                 gameObject.transform.position)
                < minDistance)
            {
                rb.velocity = new Vector2(moveSpeed * -1, 0);
            }
        }
	}
}
