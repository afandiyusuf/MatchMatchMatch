using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerGame : MonoBehaviour {

	Image timer;
	public bool isStart = false;
	float currentTime = 0;
	float TotalTime = 5;

	void Start()
	{
		timer = GetComponent<Image> ();
	}
	public void SetTotalTime(int val)
	{
		TotalTime = val;
	}
	void Update()
	{
		if (isStart) {
			currentTime += Time.deltaTime;
			timer.transform.localScale = new Vector3 (1, currentTime / TotalTime, 1);
		}
	}

	public void ResetTimer()
	{
		currentTime = 0;
	}

}
