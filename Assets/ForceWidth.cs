using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ForceWidth : MonoBehaviour {

	public Image thisImages;
	public float thisWidth;
	void Start()
	{
		
		thisImages = GetComponent<Image> ();
		thisWidth = thisImages.rectTransform.sizeDelta.x;
	}
	// Update is called once per frame
	void Update () {
		thisImages.rectTransform.sizeDelta = new Vector2 (thisWidth, 10);
	}
}
