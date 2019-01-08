using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	public GameObject restartUI;
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
		restartUI.gameObject.SetActive(true);
		GetComponent<Rigidbody>().isKinematic=true;
		GetComponent<MeshRenderer>().enabled=false;
		GetComponent<PlayerControls>().enabled=false;
		GetComponent<PlayerMove>().enabled=false;
		GetComponent<ParticleSystem>().Play();
		

		}
}
