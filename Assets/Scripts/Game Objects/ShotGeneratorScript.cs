using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGeneratorScript : MonoBehaviour {

    public GameObject shot;
    Transform tr;
	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
           GameObject shotting = Instantiate(shot,tr.position,tr.rotation);
             
        }

    }
}
