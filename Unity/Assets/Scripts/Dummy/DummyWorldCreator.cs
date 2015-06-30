using UnityEngine;
using System.Collections;
using Dystopia.Model;
using System.Collections.Generic;

namespace Dystopia.Dummy
{
	public class DummyWorldCreator : MonoBehaviour
	{
		public World dummyWorld;

		// Use this for initialization
		void Start()
		{
			dummyWorld = new DummyWorld();
			DummyLocation location1 = new DummyLocation(new Vector2(30, 30));
			DummyLocation location2 = new DummyLocation(new Vector2(200, 250));
			List<Location> locations = new List<Location>();
			locations.Add(location1);
			locations.Add(location2);
			dummyWorld.Locations = locations;
			Area area1 = new Area ();
			Area area2 = new Area ();
			area1.Neighbours = new Area[8];
			area1.Neighbours [(int)Directions.N] = area2;
			area2.Neighbours = new Area[8];
			area2.Neighbours [(int)Directions.S] = area1;


            foreach (Location location in dummyWorld.Locations)
            {
                Debug.Log(location.Coordinates);
            }
		}
		
		// Update is called once per frame
		void Update()
		{
		
		}
	}
}
