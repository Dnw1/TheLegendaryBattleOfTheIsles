using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float Speed = 0f;
	private float move = 0f;
	
	void Start () {
		
	}
	
	void FixedUpdate () {
		move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * Speed, GetComponent<Rigidbody2D>().velocity.y);
	}
}