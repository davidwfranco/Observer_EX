﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopSquare : Square {
	public TopSquare(GameObject sqObj) {
		this.squareObj = sqObj;
	}
	public override void OnNotify(string ev) {
		if (ev == "On") {
			this.squareObj.GetComponent<SpriteRenderer>().color = Color.red;
		} else if (ev == "Black") {
			this.squareObj.GetComponent<SpriteRenderer>().color = Color.black;	
		} else {
			this.squareObj.GetComponent<SpriteRenderer>().color = Color.white;			
		}
	}
}
