using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] coins;
	public GameObject player;
	public GameObject[] trees;
	public GameObject enemies;
	private float coinSpawnTimer = 7.0f;
	private float enemySpawnTimer = 10.0f;
	private float treeSpawnTimer = 0.5f;
	private Vector3 treeXSpawnStartLocation;
	private float treeStartSpawnTimes= 20;

	// Use this for initialization
void start(){
treeXSpawnStartLocation.x=-30;
SpawnStartTrees();
}
	// Update is called once per frame
	void Update () {
		coinSpawnTimer -= Time.deltaTime;
		enemySpawnTimer -= Time.deltaTime;
		treeSpawnTimer -= Time.deltaTime;
		

		if (coinSpawnTimer < 0.01 && GameInit.gameIsPlaying==false) {
			spawnCoins ();
		}
		if (enemySpawnTimer < 0.01 && GameInit.gameIsPlaying == false) {
			spawnEnemy ();
		}
		if (treeSpawnTimer < 0.01 && GameInit.gameIsPlaying == false) {
			spawnTrees ();
		}

	}

	void SpawnStartTrees(){
		while (treeStartSpawnTimes>0){
				GameObject tree=Instantiate (trees[(Random.Range (0, trees.Length))], new Vector3 (treeXSpawnStartLocation.x, 0, Random.Range (3, 22)), Quaternion.Euler(0,Random.Range(0,360),0)) as GameObject;
				tree.transform.localScale=new Vector3(Random.Range(0.9f,1.5f),Random.Range(0.9f,1.5f),Random.Range(0.9f,1.5f));
				treeXSpawnStartLocation.x=treeXSpawnStartLocation.x+5;
				treeStartSpawnTimes--;
		}
	}
	void spawnCoins () {
		Instantiate (coins[(Random.Range (0, coins.Length))], new Vector3 (player.transform.position.x + 30, Random.Range (2, 8), 0), Quaternion.identity);
		coinSpawnTimer = Random.Range (1.0f, 3.0f);
	}
	void spawnEnemy () {
		enemies.transform.localScale = new Vector3 (Random.Range (1, 3.5f), Random.Range (1, 3.5f), Random.Range (1, 3.5f));
		Instantiate (enemies, new Vector3 (player.transform.position.x + 30, Random.Range (1, 9), 0), Quaternion.identity);
		enemySpawnTimer = Random.Range (1, 3);
	}

	void spawnTrees () {
		GameObject tree=Instantiate (trees[(Random.Range (0, trees.Length))], new Vector3 (player.transform.position.x + 70, 1, Random.Range (3, 22)), Quaternion.Euler(0,Random.Range(0,360),0))as GameObject;
		tree.transform.localScale=new Vector3(Random.Range(0.9f,1.5f),Random.Range(0.9f,1.5f),Random.Range(0.9f,1.5f));
		treeSpawnTimer = 0.5f;
	
	}

}