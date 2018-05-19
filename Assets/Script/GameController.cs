using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public static GameController instance;
	public Camera cam;
	Subject sub;
	public GameObject squareObj0;
	public GameObject squareObj1;
	public GameObject squareObj2;
	public GameObject squareObj3;
	public GameObject squareObj4;
	public GameObject squareObj5;
	private Observer[] observers;

	void Awake () {
		//Check if this is the only instance of this object and if not, kills this instance
		if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        //Set the camera of the game to the "cam" variable
        if (cam == null)
        {
            cam = Camera.main;
        }
	}
	
	// Use this for initialization
	void Start () {
		sub = new Subject();
		TopSquare tSq0 = new TopSquare(squareObj0);
		TopSquare tSq1 = new TopSquare(squareObj1);
		MiddleSquare mSq0 = new MiddleSquare(squareObj2);
		MiddleSquare mSq1 = new MiddleSquare(squareObj3);
		BottomSquare bSq0 = new BottomSquare(squareObj4);
		BottomSquare bSq1 = new BottomSquare(squareObj5);

		sub.AddObservers(tSq0);
		sub.AddObservers(tSq1);
		sub.AddObservers(mSq0);
		sub.AddObservers(mSq1);
		sub.AddObservers(bSq0);
		sub.AddObservers(bSq1);			
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			this.SendNotify("On");
		} else if (Input.GetMouseButtonDown(1)) {
			this.SendNotify("Off");
		}
	}

	public void SendNotify(string ev) {
		sub.Notify(ev);
	}
}
