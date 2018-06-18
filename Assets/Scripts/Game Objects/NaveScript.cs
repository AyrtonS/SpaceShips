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
		if(GameController.instance.diedNave){
			GameController.instance.NaveDied ();
		}
		eixox = Input.GetAxis ("Horizontal");
		eixoy = Input.GetAxis ("Vertical");
	}
	void FixedUpdate(){
		print ("eixo x"+eixox);
		print (eixoy);
		nave.velocity = new Vector2 (Time.deltaTime * 100 * eixox, Time.deltaTime * 100 *eixoy);
    }	

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag ("Asteroid"))
		{
			GameController.instance.DyingNave(1);
		}
		if (other.gameObject.CompareTag ("FireFighter")) 
		{
			GameController.instance.DyingNave (3);
		}
		if (other.gameObject.CompareTag ("FireEnemy1")) 
		{
			GameController.instance.DyingNave (5);
		}
		if (other.gameObject.CompareTag ("FireEnemy2")) 
		{
			GameController.instance.DyingNave (7);
		}
		if (other.gameObject.CompareTag ("FireBigBoss")) 
		{
			GameController.instance.DyingNave (15);
		}
	}
}
