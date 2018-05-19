using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomSquare : Square {
	public BottomSquare(GameObject sqObj) {
		this.squareObj = sqObj;
	}

	public override void OnNotify(string ev) {
		if (ev == "On") {
			this.squareObj.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 300f);
		} else if (ev == "Black") {
			this.squareObj.GetComponent<SpriteRenderer>().color = Color.black;	
		} else {
			this.squareObj.GetComponent<SpriteRenderer>().color = Color.white;	
		}
	}
}
