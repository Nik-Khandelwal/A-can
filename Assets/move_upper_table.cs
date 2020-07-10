using UnityEngine;
using System.Collections;

public class move_upper_table : MonoBehaviour
{

	public GameObject character;
	private float speed = 1.0f;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)){
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D)){
			transform.position += Vector3.right* speed * Time.deltaTime;
		}

	}
}

