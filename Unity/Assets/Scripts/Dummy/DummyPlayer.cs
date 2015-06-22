using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Dystopia.Model;

namespace Dystopia.Dummy 
{
	
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