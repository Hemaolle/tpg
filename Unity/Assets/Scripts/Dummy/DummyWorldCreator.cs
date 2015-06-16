using UnityEngine;
using System.Collections;
using Dystopia.Model;
using System.Collections.Generic;

namespace Dystopia.Dummy {
	public class DummyWorldCreator : MonoBehaviour {
		public World dummyWorld;

		// Use this for initialization
		void Start () {
			dummyWorld = new DummyWorld();
			DummyLocation location1 = new DummyLocation(new Vector2(30,30));
			DummyLocation location2 = new DummyLocation(new Vector2(200,250));

		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}
