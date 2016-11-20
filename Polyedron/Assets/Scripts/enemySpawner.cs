using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	private GameObject player;
	public float enemySpawnTime = 10.0f;
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	} 

	void Update(){
		enemySpawnTime -= Time.deltaTime;

		if (enemySpawnTime < 0.01) {
			SpawnEnemy ();
		}
	}

	void SpawnEnemy() {
		enemy.transform.localScale = new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1,5));
		Instantiate(enemy, new Vector3(player.transform.position.x + 30, Random.Range(1,2), 0), Quaternion.identity);
		enemySpawnTime = Random.Range (1, 3);
	}
}
