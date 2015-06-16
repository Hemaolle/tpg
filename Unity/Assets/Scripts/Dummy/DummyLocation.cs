using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Dystopia.Model;

public class DummyLocation : Location {

	public DummyLocation(Vector2 coordinates) {
		this.coordinates = coordinates;
	}

	private Vector2 coordinates;
	public override Vector2 Coordinates {
		get {
			return coordinates;
		}
		set {
			coordinates = value;
		}
	}

}
