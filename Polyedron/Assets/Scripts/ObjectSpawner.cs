using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

	private GameObject player;
	public float enemySpawnTimer = 10.0f;
	private float coinSpawnTimer = 7.0f;
	public GameObject enemy;
	public GameObject[] coins;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	} 

	void Update(){
		enemySpawnTimer -= Time.deltaTime;
		coinSpawnTimer -= Time.deltaTime;

		if (coinSpawnTimer < 0.01) {
			SpawnCoins();
		}

		if (enemySpawnTimer < 0.01) {
			SpawnEnemy ();
		}
	}

	void SpawnEnemy() {
		enemy.transform.localScale = new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1,5));
		Instantiate(enemy, new Vector3(player.transform.position.x + 30, Random.Range(1,2), 0), Quaternion.identity);
		enemySpawnTimer = Random.Range (1.0f, 3.0f);
	}

	void SpawnCoins() {
		Instantiate(coins [(Random.Range(0, coins.Length))],  new Vector3(player.transform.position.x + 30, Random.Range (0f, 3.0f), 0), transform.rotation);
		coinSpawnTimer = Random.Range (1.0f, 5.0f);
	}
}
