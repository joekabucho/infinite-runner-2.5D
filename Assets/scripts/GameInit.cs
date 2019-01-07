using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		DataManagement.datamanagement.currentScore=0;
	 DataManagement.datamanagement.LoadData();

	}
	
	
}
