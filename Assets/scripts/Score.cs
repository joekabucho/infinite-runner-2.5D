﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

public GameObject scoreUI;
public GameObject highScoreUI;	
public GameObject coinsUI;	
	
	// Update is called once per frame
	void Update () {
		if (DataManagement.datamanagement.currentScore>DataManagement.datamanagement.highScore){
			DataManagement.datamanagement.highScore=DataManagement.datamanagement.currentScore;
		}
		scoreUI.GetComponent<Text>().text=("Score:"+DataManagement.datamanagement.currentScore.ToString());
		highScoreUI.GetComponent<Text>().text=("High Score: "+DataManagement.datamanagement.highScore.ToString());
        coinsUI.GetComponent<Text>().text=("coins collected: "+DataManagement.datamanagement.CoinsCollected.ToString());

	}
}
