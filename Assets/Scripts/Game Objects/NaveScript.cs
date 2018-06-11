using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveScript : MonoBehaviour {
	Rigidbody2D nave;
	float eixox;
	float eixoy;
	void Start () {
		nave = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		eixox = Input.GetAxis ("Horizontal");
		eixoy = Input.GetAxis ("Vertical");
	}
	void FixedUpdate(){
		print (eixox);
		print (eixoy);
		nave.velocity = new Vector2 (nave.velocity.x * eixox,nave.velocity.y* eixoy);
	}	
}
