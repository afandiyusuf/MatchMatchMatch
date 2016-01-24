using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextScoreController : MonoBehaviour {
	Text score_text;

	void Start()
	{
		score_text = GetComponent<Text> ();
	}
	public void UpdateScore(int val)
	{
		string defText = val.ToString ();
		string newText = "";

		for (int i = 0; i < defText.Length; i++) {
			if (i != 0) {
				newText += " ";
			}
			newText += defText[i];
		}

		score_text.text = newText;
	}


}
