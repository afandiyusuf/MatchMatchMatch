using UnityEngine;
using System.Collections;

public class TileGroupController : PuzzleTile {
	private SoundManager SM;

	void Start()
	{
		SM = GameObject.FindGameObjectWithTag ("SoundManager").GetComponent<SoundManager> ();
		if(playerManager == null)
			playerManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerManager> ();


		ToggleTile ();
		playerManager.ChangeIndexPuzzle(thisIndex,0);


	}
	void OnMouseDown()
	{
		ToggleTile ();
		playerManager.ChangeIndexPuzzle(thisIndex,conditionIndex);
		if(thisIndex == 0)
			SM.PlayClick1 ();
		else if(thisIndex == 1)
			SM.PlayClick2 ();
		else
			SM.PlayClick3 ();
	}

}
