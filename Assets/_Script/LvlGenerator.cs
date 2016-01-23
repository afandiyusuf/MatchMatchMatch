using UnityEngine;
using System.Collections;

public class LvlGenerator : MonoBehaviour {


	public GameObject[] allLevelPuzzle;
	public GameObject[] allInitPositioner;
	public GameObject[] allPuzzlePositioner;
	public bool isPressed;
	public int timers = 5;
	public bool isStart = false;
	public TimerGame timerGame;

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
		timerGame.ResetTimer ();
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
		}else{

		}

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
			iTween.MoveTo (allLevelPuzzle [i], allPuzzlePositioner [i].transform.position, 0.8f);
		}
	}

}
