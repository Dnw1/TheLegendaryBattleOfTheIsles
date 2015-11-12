using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float Speed = 0f;
	private float moveSide = 0f;
	private float moveAbove = 0f;
	
	void Start () {
		
	}
	
	void FixedUpdate () {
		moveSide = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSide * Speed, GetComponent<Rigidbody2D>().velocity.y);
		moveAbove = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (moveAbove * Speed, GetComponent<Rigidbody2D>().velocity.x);
	}
}