using UnityEngine;
using System.Collections;

public class TileGroupController : PuzzleTile {

	void Start()
	{
		if(playerManager == null)
			playerManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerManager> ();


		ToggleTile ();
		playerManager.ChangeIndexPuzzle(thisIndex,0);


	}
	void OnMouseDown()
	{
		ToggleTile ();
		playerManager.ChangeIndexPuzzle(thisIndex,conditionIndex);
	
	}

}
