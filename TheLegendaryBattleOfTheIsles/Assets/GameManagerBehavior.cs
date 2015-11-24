using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour {

	public Text goldLabel;
	private int gold;

	public int Gold {
		get { return gold; }
		set {
			gold = value;
			goldLabel.GetComponent<Text> ().text = "MANA:" + gold;
		}
	}
	public void Start(){
		Gold = 1000;
	}
}
