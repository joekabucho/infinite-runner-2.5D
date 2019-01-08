using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour {
public static bool gameIsPlaying;
	// Use this for initialization
	void Awake () {
		gameIsPlaying=true;
		DataManagement.datamanagement.currentScore=0;
	 DataManagement.datamanagement.LoadData();

	}
	
	
}
