using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour {
	public GameObject character;
	private float speed = 10.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.position += Vector3.left* speed * Time.deltaTime;
		}

	}
}
