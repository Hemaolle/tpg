using UnityEngine;
using System.Collections;

namespace Dystopia.Model {
	
	[System.Serializable]
	public class Player {

		public Area CurrentArea {
			get;
			set;
		}

		public string Name {
			get;
			set;
		}

		public void MoveTo(Area area) {

		}
	}
}