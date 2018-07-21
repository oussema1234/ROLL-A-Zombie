using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
public GameObject c;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag=="Player")
		{
			c.GetComponent<GameManaged>().addScore();
			GetComponent<AudioSource>().Play();
		}
		
		
		
	}
}
