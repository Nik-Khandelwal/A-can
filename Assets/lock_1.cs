using UnityEngine;
using System.Collections;

public class lock_1 : MonoBehaviour
{
	float speed = 3f;
	bool onoff = false;
	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.L)){
			onoff = !onoff;
			if (onoff == true) {
				transform.position += Vector3.down*speed;
			}
			if (onoff == false){
				transform.position += Vector3.up*speed;
			}
		}
	}
}

