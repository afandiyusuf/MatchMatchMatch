using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour {

	public void GotoPlay()
	{
		SceneManager.LoadScene (1);
	}

	public void GotoMainMenu()
	{
		SceneManager.LoadScene (0);
	}

	public void ExitMenu()
	{
		Application.Quit ();
	}


}
