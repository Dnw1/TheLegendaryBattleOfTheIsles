using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	[SerializeField] private float movementSpeed;
	// Use this for initialization
	private Rigidbody2D rb2d;
	void Awake () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Start () {
		Vector2 newVelocity = new Vector2 (movementSpeed, 0f);
		rb2d.velocity = newVelocity;
	}
}
