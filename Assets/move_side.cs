using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class move_side : MonoBehaviour
{
	public GameObject character;
	private float speed = 3.0f;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)){
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			transform.position += Vector3.back* speed * Time.deltaTime;
		}

	}
}
