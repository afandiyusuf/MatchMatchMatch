using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGameController : MonoBehaviour {

	public Text currentScore;
	public Text bestScore;

	void Start()
	{
		currentScore.text = PlayerPrefs.GetInt ("CurrentScore", 0).ToString();
		bestScore.text = PlayerPrefs.GetInt ("BestScore", 0).ToString();
	}
}
