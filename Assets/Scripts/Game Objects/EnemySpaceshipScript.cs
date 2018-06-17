using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaceshipScript : MonoBehaviour {

    Rigidbody2D rb;
    public int speed;
   
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * speed *Time.deltaTime);
    }

}
