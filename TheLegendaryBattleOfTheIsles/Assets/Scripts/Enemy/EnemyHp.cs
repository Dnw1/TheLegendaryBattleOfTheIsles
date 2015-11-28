using UnityEngine;
using System.Collections;

public class EnemyHp : MonoBehaviour {

	[SerializeField]private int Hp;
	[SerializeField]private int ManaDrop = 100;

	public void HpManager()
	{
		if (Hp <= 1) {
			Destroy (this.gameObject);
			GameObject.Find ("Main Camera").GetComponent<ManaController> ().Mana += ManaDrop;
		} else {
			Hp = Hp - 1;
		}
     }
	public void ReachedEnd()
	{
		Destroy (this.gameObject);
	}
}
