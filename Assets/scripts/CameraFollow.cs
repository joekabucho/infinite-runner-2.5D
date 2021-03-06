﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


private GameObject player;
public float cameraSpeed=5.0f;
	// Use this for initialization
	void Start () {
		player= GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(GameInit.gameIsPlaying==true){
		//X position follow
		Vector3 camPos=transform.position;
		camPos.x=player.transform.position.x + 8.0f;
		transform.position=Vector3.Lerp(transform.position,camPos,3*Time.deltaTime);

		//y position follow
		camPos.y=player.transform.position.y +2;
		transform.position=Vector3.Lerp (transform.position,camPos,7.0f * Time.fixedDeltaTime);
		}
		else{
			Vector3 deathCamPos=transform.position;
			deathCamPos.x=player.transform.position.x;
			transform.position=Vector3.Lerp(transform.position,deathCamPos,2.0f*Time.fixedDeltaTime);

		}

	}
}
