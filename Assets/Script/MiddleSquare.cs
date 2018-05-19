using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleSquare : Square {
	public MiddleSquare(GameObject sqObj) {
		this.squareObj = sqObj;
	}
	public override void OnNotify(string ev) {
		if (ev == "On") {
			this.squareObj.GetComponent<SpriteRenderer>().color = Color.yellow;
		} else if (ev == "Black") {
			this.squareObj.GetComponent<SpriteRenderer>().color = Color.black;	
		} else {
			this.squareObj.GetComponent<SpriteRenderer>().color = Color.white;			
		}
	}
}
