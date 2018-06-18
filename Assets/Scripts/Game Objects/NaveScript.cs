using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveScript : MonoBehaviour {
	Rigidbody2D nave;
	float eixox;
	float eixoy;
    public GameObject shot; 

	void Start () {
		nave = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		
		eixox = Input.GetAxis ("Horizontal");
		eixoy = Input.GetAxis ("Vertical");
        
	}
	void FixedUpdate(){
		nave.velocity = new Vector2 (Time.deltaTime * 100 * eixox, Time.deltaTime * 100 *eixoy);
		if(GameController.instance.diedNave == true){
			GameController.instance.NaveDied ();
		}
	}	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.layer == 8)
		{
			Destroy (collision.gameObject);
			GameController.instance.DyingNave (3);
			NaveScriptHealth.instance.TakeDamage (3);


		}
		if(collision.gameObject.layer == 9){
			Destroy (collision.gameObject);
			GameController.instance.DyingNave (1);
			NaveScriptHealth.instance.TakeDamage (1);
		}
	}
}
