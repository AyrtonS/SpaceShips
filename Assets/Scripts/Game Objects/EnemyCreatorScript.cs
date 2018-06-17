using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreatorScript : MonoBehaviour {


    public GameObject enemy;
    Transform thisTransform;
    public GameObject[] enemies =  new GameObject[4];

	// Use this for initialization
	void Start () {
        StartCoroutine(CreateEnemy());
        thisTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator CreateEnemy() {
        while (true)
        {
            GameObject e = Instantiate(enemies[Random.Range(0,4)],new Vector2(Random.Range(-6, 10), gameObject.transform.position.y),gameObject.transform.rotation);
           
            yield return new WaitForSeconds(0.5f);
        }
    }



}
