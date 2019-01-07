using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
void OnCollisionEnter(Collision col){
	if (col.gameObject.tag=="Enemy"){
		Dies();
	}
}
	void OnTriggerEnter(Collider trig){
		if (trig.gameObject.tag=="Coin")
		{
		DataManagement.datamanagement.CoinsCollected ++;
		DataManagement.datamanagement.currentScore++;
			//play audio affect
			Destroy(trig.gameObject);
		}

	
	}
		void Dies(){
			//playerdeath audio
		DataManagement.datamanagement.SaveData();
			//activate ui or starting game
         Application.LoadLevel("main");
		}
}
