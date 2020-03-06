using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;
    public int numberOfCoins;
    Rigidbody2D rb;

    public bool isGrounded;

    // Use this for initialization
	void Start () {

        // we equate rb and tell the script that this rb is the rigidbody attached to the gameObject
        // this script sits on
        rb = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        float Horizontal = Input.GetAxis("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(Horizontal, rb.velocity.y);

        // setting the isGrounded value
        if (rb.velocity.y == 0) {
            isGrounded = true;
        } else {
            isGrounded = false;
        }


        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Vector2 jump = new Vector2(0, jumpForce);
                rb.AddForce(new Vector2(0, jumpForce));
            }
        }

    }

    // Called whenever Player object collides with any other object
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Enemy") {
            Destroy(gameObject);
        }
    }

    public void addCoins() {
        numberOfCoins = numberOfCoins + 1;
    }

    public int returnCoins() {
        return numberOfCoins;
    }
}
