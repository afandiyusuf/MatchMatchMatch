using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LvlGenerator : MonoBehaviour {


	public GameObject[] allLevelPuzzle;
	public GameObject[] allInitPositioner;
	public GameObject[] allPuzzlePositioner;
	public bool isPressed;
	public int timers = 5;
	public bool isStart = false;
	public TimerGame timerGame;
	public TextScoreController textScoreController;
	public float initialScore = 300;
	public int currentScore = 0;

	void Start()
	{
		
		ResetPosition ();
		timerGame.SetTotalTime (timers);
	}

	public void DisableAll()
	{
		for(int i =0;i<3;i++)
		{
			allLevelPuzzle[i].SetActive(false);
		}	
	}

	public void EnableAll()
	{
		for(int i =0;i<3;i++)
		{
			allLevelPuzzle[i].SetActive(true);
		}
	}

	public void StartCompare()
	{
		
		isStart = true;
		timerGame.isStart = false;

		if (isPressed)
			return;

		isPressed = true;
		GotoPuzzle ();
		if(GetComponent<PlayerManager> ().compareArrIndex () == true)
		{
			Invoke ("ResetPosition", 1);
			Invoke ("ResetTimer", 1);
			currentScore += GetScore();
			textScoreController.UpdateScore (currentScore);
			timerGame.ResetTimer ();
		}else{
			Invoke ("GotoGameOver",1);

		}

	}

	public void GotoGameOver()
	{
		PlayerPrefs.SetInt ("CurrentScore", currentScore);
		if (currentScore > PlayerPrefs.GetInt ("BestScore", 0)) {
			PlayerPrefs.SetInt ("BestScore", currentScore);
		}
		SceneManager.LoadScene (2);
	}

	public void ResetTimer()
	{
		timerGame.isStart = true;
	}
	public void ResetPosition()
	{
		
		DisableAll ();
		EnableAll ();

		isPressed = false;
		for(int i =0;i<3;i++)
		{
			allLevelPuzzle [i].transform.position = allInitPositioner [i].transform.position;
		}
	}


	public void GotoPuzzle()
	{
		for (int i = 0; i < 3; i++) {
			Vector3 posTarget = allPuzzlePositioner [i].transform.position;
			posTarget.z = -1;
			iTween.MoveTo (allLevelPuzzle [i],posTarget, 0.8f);
		}
	}

	public int GetScore()
	{
		return Mathf.FloorToInt (timerGame.currentTime / timerGame.TotalTime * initialScore);
	}

}
