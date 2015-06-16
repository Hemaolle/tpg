using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Dystopia.Model {

	// An area where the player is located. For exapmle a shop or
	// the city hall
	[System.Serializable]
	public class Area {

		public List<Player> Players {
			get;
			set;
		}

		public Location ParentLocation {
			get;
			set;
		}

		public string Description {
			get;
			set;
		}

		public List<Area> Neighbours {
			get;
			set;
		}
	}
}