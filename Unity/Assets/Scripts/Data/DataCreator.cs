using UnityEngine;
using UnityEditor;

public class DataCreator
{
	[MenuItem("TPG/Create/AreaData")]
	public static void CreateAsset ()
	{
		ScriptableObjectUtility.CreateAsset<AreaData> ();
	}
}