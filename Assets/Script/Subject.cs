using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject {
	//A list with observers that are waiting for something to happen
	List<Observer> observers = new List<Observer>();

	//Send notifications if something has happened
	public void Notify(string ev) {
		for (int i = 0; i < observers.Count; i++) {
			//Notify all observers even though some may not be interested in what has happened
			//Each observer should check if it is interested in this event
			observers[i].OnNotify(ev);
		}
	}

	// Add a observer to the list
	public void AddObservers(Observer o) {
		observers.Add(o);
	}

	//Remove observer from the list
	public void RemoveObserver(Observer observer) {
	}
}
