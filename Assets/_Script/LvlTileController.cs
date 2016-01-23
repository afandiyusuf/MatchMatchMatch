using UnityEngine;
using System.Collections;

public class LvlTileController : PuzzleTile {

	void OnEnable()
	{
		RandomThis ();
	}

	void Start()
	{
		RandomThis ();
	}

	public void RandomThis()
	{
		if(playerManager == null)
			playerManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerManager> ();


		int randomNumber = Random.Range (0, 4);
		Debug.Log ("condition random " + conditionIndex);


		for (int i = 0; i < randomNumber; i++) {
			ToggleTile ();
		}


		playerManager.ChangeIndexLvl (thisIndex, conditionIndex);
	}
}
