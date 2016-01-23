using UnityEngine;
using System.Collections;

public class PuzzleTile : MonoBehaviour {

	public int thisIndex = 0;
	protected int conditionIndex = 3;
	public SpriteRenderer[] allTile;
	public PlayerManager playerManager;

	void Start()
	{
		playerManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerManager> ();
		DeactiveAll ();
		ToggleTile ();
	}

	protected void ToggleTile()
	{
		DeactiveAll();
		conditionIndex++;
		if(conditionIndex == 4)
			conditionIndex = 0;
		
		if (conditionIndex == 0) {
			SetActiveNum (0);
		} else if (conditionIndex == 1) {
			Debug.Log (conditionIndex);
			SetActiveNum (1);
			SetActiveNum (0);
		} else if (conditionIndex == 2) {
			Debug.Log (conditionIndex);
			SetActiveNum (1);
			SetActiveNum (2);
			SetActiveNum (0);
		} else {
			SetActiveNum (1);
			SetActiveNum (2);
			SetActiveNum (3);
			SetActiveNum (0);
		}

	}



	void SetActiveNum(int index)
	{
		for (int i = 0; i < allTile.Length; i++) {
			if (i == index) {
				allTile [i].gameObject.SetActive (true);
				return;
			}
		}
	}

	void DeactiveAll()
	{
		for (int i = 0; i < allTile.Length; i++) {
			allTile [i].gameObject.SetActive (false);
		}
	}
}
