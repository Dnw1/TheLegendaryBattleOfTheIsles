using UnityEngine;
using System.Collections;

public class EndofTheLine : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			Debug.Log("Triggered");
			IslandHp.instance.IslandHealth = IslandHp.instance.IslandHealth - 1;
			col.GetComponent<EnemyHp>().ReachedEnd();
		}
     }
}
