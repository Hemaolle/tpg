using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Dystopia.Model {

	// A location is for example a city, contains multiple areas
	[System.Serializable]
	public class Location {

		public List<Area> Areas {
			get;
			set;
		}

		public virtual Vector2 Coordinates {
			get;
			set;
		}
	}
}
