using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour {

	private void DuplicateGotoPlay()
	{
		SceneManager.LoadScene (1);
	}
	public void GotoPlay()
	{
		Invoke ("DuplicateGotoPlay", 0.5f);
	}

	public void GotoMainMenu()
	{
		Invoke ("DuplicateGotoMainMenu", 0.5f);
	}

	private void DuplicateGotoMainMenu()
	{
		SceneManager.LoadScene (0);
	}

	public void ExitMenu()
	{
		Invoke ("DuplicateGotoExitMenu", 0.5f);;
	}

	private void DuplicateGotoExitMenu()
	{
		Application.Quit ();
	}


}
