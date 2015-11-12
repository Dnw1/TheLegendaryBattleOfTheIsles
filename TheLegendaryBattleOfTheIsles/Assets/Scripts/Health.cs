using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	private float BaseHp;
	private float EnemyHp;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void BaseHealth(){
		BaseHp = 10;
	}
	private void EnemyHealth(){
		EnemyHp = 2;
	}
}
