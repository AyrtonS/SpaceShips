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
		print ("eixo x"+eixox);
		print (eixoy);
		nave.velocity = new Vector2 (Time.deltaTime * 100 * eixox, Time.deltaTime * 100 *eixoy);
        
    }	
}
