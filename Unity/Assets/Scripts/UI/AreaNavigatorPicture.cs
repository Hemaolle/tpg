using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AreaNavigatorPicture : MonoBehaviour {

	public Image areaPicture;
	public GameObject areaLinkButton;
	public RectTransform panel;

	public AreaData startingArea;

	void SetCurrentArea(AreaData areaData) {
		areaPicture.sprite = areaData.Picture;
		foreach (AreaData.AreaLink link in areaData.areaLinks) {
			GameObject newButton = Instantiate(areaLinkButton) as GameObject;
			newButton.transform.SetParent(panel);
			newButton.GetComponent<RectTransform>().anchoredPosition = link.LinkLocation;
		}
	}

	// Use this for initialization
	void Start () {
		SetCurrentArea (startingArea);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
