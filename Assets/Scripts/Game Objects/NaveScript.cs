using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveScript : MonoBehaviour {
	Rigidbody2D nave;
	float eixox;
	float eixoy;
	NaveScriptHealth naveScriptHealth;
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
		if(GameController.instance.diedNave == true){
			GameController.instance.NaveDied ();
		}
	}	

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag ("Asteroid"))
		{
			if(naveScriptHealth.currentHealth > 0)
			{
				naveScriptHealth.TakeDamage (1);
			}
			GameController.instance.DyingNave(1);
		}
		if (other.gameObject.CompareTag ("FireFighter")) 
		{
			if(naveScriptHealth.currentHealth > 0)
			{
				naveScriptHealth.TakeDamage (3);
			}
			GameController.instance.DyingNave (3);
		}
		if (other.gameObject.CompareTag ("FireEnemy1")) 
		{
			if(naveScriptHealth.currentHealth > 0)
			{
				naveScriptHealth.TakeDamage (5);
			}
			GameController.instance.DyingNave (5);
		}
		if (other.gameObject.CompareTag ("FireEnemy2")) 
		{
			if(naveScriptHealth.currentHealth > 0)
			{
				naveScriptHealth.TakeDamage (7);
			}
			GameController.instance.DyingNave (7);
		}
		if (other.gameObject.CompareTag ("FireBigBoss")) 
		{
			if(naveScriptHealth.currentHealth > 0)
			{
				naveScriptHealth.TakeDamage (15);
			}
			GameController.instance.DyingNave (15);
		}
	}
}
