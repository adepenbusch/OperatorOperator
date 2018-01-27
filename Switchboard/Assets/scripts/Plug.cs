using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plug : MonoBehaviour {
	
	public static GameObject gameController;

	private int row = -1;
	private int col = -1;

	// Use this for initialization
	void Start () {
		if (gameController == null) {
			gameController = GameObject.Find ("GameController");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		// this object was clicked - do something
		gameController.GetComponent<GameController>().triggerPlug(gameObject);
	}

	public void setPosition(int x, int y) {
		col = x;
		row = y;
	}

	public override string ToString() {
		return "Plug(" + col + ", " + row + ")";
	}
}
