using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {

    Rigidbody2D rb;
    public AudioClip explosion;
  
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
       

        Destroy(gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0,rb.velocity.y * 100 *Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
              Destroy(gameObject);
              Destroy(collision.gameObject);
			  GameController.instance.NaveScored (7);
			 
        }
		if(collision.gameObject.layer == 9){
			Destroy (gameObject);
			Destroy (collision.gameObject);
			GameController.instance.NaveScored (1);
		}
    }

}
