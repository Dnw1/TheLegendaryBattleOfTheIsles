using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	[SerializeField] private GameObject objectToSpawn;
	[SerializeField] private GameObject objectToSpawn2;
	[SerializeField]private float SpawnCounting;

	void Start(){
		StartCoroutine (SpawnEnemy ());
	}

	IEnumerator SpawnEnemy()
	{
		while (SpawnCounting < 200) {
			GameObject obj = Instantiate (objectToSpawn, this.transform.position, Quaternion.identity) as GameObject;
			obj.transform.SetParent (this.transform);
			SpawnCounting = SpawnCounting + 1;
			yield return new WaitForSeconds(3);
		}
	}
}
		/* Code I intended to use for spawning boss but he cannot move
		if(SpawnCounting == 6 && SpawnCounting < 7) {
			GameObject obj = Instantiate (objectToSpawn2, this.transform.position, Quaternion.identity) as GameObject;
			obj.transform.SetParent (this.transform);
	    } */
