using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public Transform exit;
    static Transform last;
    public bool canTeleport;

	void OnTriggerEnter2D ( Collider2D other )
	{
        if (exit == last && canTeleport)
        {
            return;
        }
		TeleportToExit2D (other);
        canTeleport = false;
	}
	void OnTriggerExit2D ( )
	{
		last = null;
        canTeleport = true;
	}
	void TeleportToExit2D ( Collider2D other )
	{
		last = transform;
		other.transform.position = exit.transform.position;
	}
}
