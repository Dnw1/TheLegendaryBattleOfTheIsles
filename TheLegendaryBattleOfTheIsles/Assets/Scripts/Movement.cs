using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float Speed = 0f;
	private float moveSide = 0f;
	private float moveAbove = 0f;
	public Transform groundCheck;
	bool grounded = false;
	
	void Start () {
		//Ground = GameObject.FindGameObjectWithTag("Ground");
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1<< LayerMask.NameToLayer("Eilanden"));
	}
	
	void Update(){
		//GetComponent<Collider>() = GameObject.FindGameObjectsWithTag("Ground");
		//if(GetComponent<Collider>())
		//{
		moveSide = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSide * Speed, GetComponent<Rigidbody2D>().velocity.y);
		moveAbove = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (moveAbove * Speed, GetComponent<Rigidbody2D>().velocity.x);
		//}
	}
}
