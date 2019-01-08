using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

	public GameObject[] coins;
	public GameObject player;
	public GameObject[] trees;
	public GameObject enemies;
	private float coinSpawnTimer = 7.0f;
	private float enemySpawnTimer = 10.0f;
	private float treeSpawnTimer = 0.5f;

	// Use this for initialization

	// Update is called once per frame
	void Update () {
		coinSpawnTimer -= Time.deltaTime;
		enemySpawnTimer -= Time.deltaTime;
		treeSpawnTimer -= Time.deltaTime;

		if (coinSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
			spawnCoins ();
		}
		if (enemySpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
			spawnEnemy ();
		}
		if (treeSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
			spawnTrees ();
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
		Instantiate (trees[(Random.Range (0, trees.Length))], new Vector3 (player.transform.position.x + 70, 1, Random.Range (3, 22)), Quaternion.identity);
		treeSpawnTimer = 0.5f;
	}

}