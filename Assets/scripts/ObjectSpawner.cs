using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectSpawner : MonoBehaviour {

public GameObject[] coins;
public GameObject player;
public GameObject enemies;
private float coinSpawnTimer=7.0f;
private float enemySpawnTimer=10.0f;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		coinSpawnTimer -=Time.deltaTime;
				enemySpawnTimer -=Time.deltaTime;
		
		if(coinSpawnTimer<0.01){
          spawnCoins();
		}
		if(enemySpawnTimer<0.01){
          spawnEnemy();
		}
	
	}
	void spawnCoins(){
		Instantiate(coins[(Random.Range(0,coins.Length))],new Vector3 (player.transform.position.x+30,Random.Range(2,8),0),Quaternion.identity);
		coinSpawnTimer = Random.Range(1.0f,3.0f)  ;
	}
	void spawnEnemy(){
		enemies.transform.localScale=new Vector3(Random.Range(1,3.5f),Random.Range(1,3.5f),Random.Range(1,3.5f));
		Instantiate(enemies,new Vector3(player.transform.position.x+30,Random.Range(1,9),0),Quaternion.identity);
		enemySpawnTimer=Random.Range(1,3);
	}

}
