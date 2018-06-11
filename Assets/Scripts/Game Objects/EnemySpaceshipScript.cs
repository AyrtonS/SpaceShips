using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpaceshipScript : MonoBehaviour {

    Rigidbody2D rb;
    public int speed;
    public GameObject player;
    Transform tr;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }

    private void Update()
    {
        tr.LookAt(player.transform);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * speed *Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("killerWall")) {
            Destroy(gameObject);
        }
    }

}
