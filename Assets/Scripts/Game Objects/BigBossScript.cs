using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBossScript : MonoBehaviour {

	void update(){
		if(GameController.instance.diedBigBoss)
		{
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag ("FireNave"))
		{
			GameController.instance.NaveScored (7);
			GameController.instance.DyingBigboss (8);
		}
	}
}
