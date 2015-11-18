using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public Transform exit;
	static Transform last;

	void OnTriggerEnter2D ( Collider2D other )
	{
			if (exit == last)
				return;
			TeleportToExit2D (other);
	}
	void OnTriggerExit2D ( )
	{
		 	 last = null;
	}
	void TeleportToExit2D ( Collider2D other )
	{
		last = transform;
		other.transform.position = exit.transform.position;
	}
}
