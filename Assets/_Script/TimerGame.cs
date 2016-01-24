using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerGame : MonoBehaviour {

	Image timer;
	public bool isStart = false;
	public float currentTime = 0;
	public float TotalTime = 5;
	private LvlGenerator lvlGenerator;
	public float initWidth;

	void Start()
	{
		lvlGenerator = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<LvlGenerator> ();
		currentTime = TotalTime;
	
		timer = GetComponent<Image> ();

		initWidth = timer.rectTransform.sizeDelta.x;
	}
	public void SetTotalTime(int val)
	{
		TotalTime = val;
	}
	void Update()
	{
		if (isStart) {
			currentTime -= Time.deltaTime;
			float now = initWidth * currentTime / TotalTime;
			timer.rectTransform.sizeDelta = new Vector2 (now, 10);
			if (now < 0) {
				lvlGenerator.GotoGameOver ();
			}
		}
	}


	public void ResetTimer()
	{
		currentTime = TotalTime;
	}

}
