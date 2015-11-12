using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour {

	public Transform[] Waypoints;
	public float Speed;
	public int currentWaypoint;
	public bool doPatrol = true;
	public Vector3 Target;
	public Vector3 MoveDirection;
	public Vector3 Velocity;

	void Update()
	{
		if (currentWaypoint < Waypoints.Length) 
		{
			Target = Waypoints[currentWaypoint].position;
			MoveDirection = Target - transform.position;
			Velocity = GetComponent<Rigidbody>().velocity;
		}
	}

}
