using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	[SerializeField] private GameObject objectToSpawn;
	[SerializeField] private float spawnTimer;

	void Start(){
		InvokeRepeating("SpawnEnemy", 0.5f , spawnTimer);
	}

	private void SpawnEnemy()
	{
		GameObject obj = Instantiate (objectToSpawn, this.transform.position, Quaternion.identity) as GameObject;
		obj.transform.SetParent (this.transform);
	}
}
