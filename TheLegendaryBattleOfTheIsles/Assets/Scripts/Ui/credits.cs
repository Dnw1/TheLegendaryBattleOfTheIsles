﻿using UnityEngine;
using System.Collections;
//Dylan Waij

public class credits : MonoBehaviour {

	public GUISkin guiskin;

	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.32f, Screen.height * 0.08f, 575, 575), "Credits");
		GUI.Label (new Rect (Screen.width * 0.48f,Screen.height * 0.21f,Screen.width * 0.2f,Screen.height * 0.1f), "Beau van Boxtel");
		GUI.Label (new Rect (Screen.width * 0.48f, Screen.height * 0.27f, Screen.width * 0.2f, Screen.height * 0.1f), "Kevin Weppnerl");
		GUI.Label (new Rect (Screen.width * 0.48f, Screen.height * 0.33f, Screen.width * 0.2f, Screen.height * 0.1f), "Dylan Waij");
		GUI.Label (new Rect (Screen.width * 0.48f, Screen.height * 0.39f, Screen.width * 0.2f, Screen.height * 0.1f), "Danny van Der Zee");
		GUI.Label (new Rect (Screen.width * 0.48f, Screen.height * 0.45f, Screen.width * 0.2f, Screen.height * 0.1f), "Donovan Nguyen");
		if (GUI.Button (new Rect (Screen.width * 0.42f, Screen.height * 0.7f, Screen.width * 0.2f, Screen.height * 0.1f), "Main Menu")) {
			Application.LoadLevel ("MainMenu");
		}
	}
}