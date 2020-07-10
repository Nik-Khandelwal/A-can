using UnityEngine;
using System.Collections;

public class rot1 : MonoBehaviour
{
	public GameObject objectToScale;
	public float rotationSpeed;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey(KeyCode.R))
		{
			// If the player is holding the key, rotate the object.
			objectToScale.transform.Rotate(0,0,5);
		}
	}
}

