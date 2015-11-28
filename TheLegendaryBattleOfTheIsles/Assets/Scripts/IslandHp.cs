using UnityEngine;
using System.Collections;

public class IslandHp : MonoBehaviour {

	public static IslandHp instance;
	public int IslandHealth = 3;

	void Start()
	{
		instance = this;
	}
	void Update()
	{
		HealthManager ();
	}
	public void HealthManager()
	{
		if (IslandHealth < 1) {
			Application.LoadLevel ("Credits");
		}
     }
}
