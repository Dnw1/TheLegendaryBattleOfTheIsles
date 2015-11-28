using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float Speed = 0f;
	private float moveSide = 0f;
	private float moveAbove = 0f;
	//public bool grounded = false;
	
	void Update(){
		PlayerMovement ();
	}/*
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Ground") {
			grounded = true;
		}
		if (other.tag == "Water") {
			grounded = false;
			Debug.Log("Halt");
		}
	}*/
	void PlayerMovement(){
		//GetComponent<Collider>() = GameObject.FindGameObjectsWithTag("Ground");
		//if (grounded) {
			moveSide = Input.GetAxis ("Vertical");
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSide * Speed, GetComponent<Rigidbody2D> ().velocity.y);
			moveAbove = Input.GetAxis ("Horizontal");
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveAbove * Speed, GetComponent<Rigidbody2D> ().velocity.x);
		/*} else {
			GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
		}*/
	}
}
