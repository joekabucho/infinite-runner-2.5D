using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public static int playerSpeed=10;

	// Use this for initialization

	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Translate(Vector3.right *playerSpeed* Time.fixedDeltaTime);
	}
}
