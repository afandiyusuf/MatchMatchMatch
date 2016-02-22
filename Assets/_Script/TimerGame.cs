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
	Image skin;
	public bool isReset;
	public bool timerGo;

	void Start()
	{
		skin = GetComponent<Image> ();
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
			if (!isReset) {
				if(timerGo)
				currentTime -= Time.deltaTime;
			} else {
				currentTime = Mathf.Lerp (currentTime, TotalTime*1.2f, Time.deltaTime*4);
				if (currentTime > TotalTime) {
					currentTime = TotalTime;
					isReset = false;
				}
			}
			float now =  currentTime;
			skin.fillAmount = currentTime / TotalTime;
			//timer.rectTransform.sizeDelta = new Vector2 (now, 10);
			if (currentTime > TotalTime) {
				lvlGenerator.GotoGameOver ();
			}
		}
	}


	public void ResetTimer()
	{
		isReset = true;
		timerGo = false;
		TotalTime -= TotalTime / 100;
	}

	public void SetTimerFalse()
	{
		timerGo = true;
	}




}
