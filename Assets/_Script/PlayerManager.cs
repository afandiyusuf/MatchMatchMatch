using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
	
	public int[] arrPuzzleIndex = new int[3];
	public int[] arrLvlIndex = new int[3];

	public void ChangeIndexPuzzle(int numIndex,int val)
	{
		
		arrPuzzleIndex [numIndex] = val;
	}

	public void ChangeIndexLvl(int numIndex,int val)
	{
		
		arrLvlIndex [numIndex] = val;
	}

	public bool compareArrIndex()
	{
		for (int i = 0; i < arrPuzzleIndex.Length; i++) {
			if (arrLvlIndex [i] != arrPuzzleIndex[i])
				return false;
		}


		return true;
	}




}
