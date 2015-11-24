using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	[SerializeField] private GameObject objectToSpawn;
	[SerializeField] private GameObject objectToSpawn2;
	[SerializeField] private GameObject objectToSpawn3;
	[SerializeField] private float spawnTimer;
	private float SpawnCounting;
	private 

	void Start(){
		InvokeRepeating("SpawnEnemy", 0.5f , spawnTimer);
	}

	private void SpawnEnemy()
	{
		if (SpawnCounting < 6) {
			GameObject obj = Instantiate (objectToSpawn, this.transform.position, Quaternion.identity) as GameObject;
			obj.transform.SetParent (this.transform);
			SpawnCounting = SpawnCounting++;
		}//Needs a click controller via ui.
		if (SpawnCounting > 4 || SpawnCounting < 11){
			GameObject obj = Instantiate (objectToSpawn, this.transform.position, Quaternion.identity) as GameObject;
			obj.transform.SetParent (this.transform);
			SpawnCounting = SpawnCounting++;
		}
	}
}
