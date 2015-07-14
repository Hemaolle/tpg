using UnityEngine;
using System.Collections;

public class AreaData : ScriptableObject {
	public string Description;
	public Sprite Picture;
	public AreaLink[] areaLinks;

	[System.Serializable]
	public class AreaLink {
		public Vector2 LinkLocation;
		public AreaData LinkedArea;
	}
}
