using UnityEngine;
using System.Collections;

public class TowerTarget : MonoBehaviour {

	private GameObject target;
	[SerializeField] private float targettingRadius;
	private int layerMask;

	void Start(){
		layerMask = LayerMask.GetMask ("Enemy");
	}

	// Update is called once per frame
	void Update () {
		Collider2D col = Physics2D.OverlapCircle(this.transform.position, targettingRadius, layerMask);
		Debug.Log (col);
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere (this.transform.position, targettingRadius);
	}
}
