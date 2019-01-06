using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	void onTriggarEnter(Collider trig){
		if (trig.gameObject.tag=="Coin")
		{
			//inc score
			//inc coin collection
			//play audio affect
			Destroy(trig.gameObject);
		}
	}
}
