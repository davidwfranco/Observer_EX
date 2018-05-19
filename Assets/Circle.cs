using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {
	private GameController gControll;
	// Use this for initialization
	void Start () {
		gControll = GameController.instance;
	}

	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("AAAAAAAAAAAAAA");
		gControll.SendNotify("Black");
	}

	void OnTriggerExit2D(Collider2D other) {
		gControll.SendNotify("Off");	
	}
}
