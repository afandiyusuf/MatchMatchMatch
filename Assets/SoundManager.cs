using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	public AudioClip click1;
	public AudioClip click2;
	public AudioClip click3;
	public AudioClip enterSound;
	public AudioClip trueSound;
	public AudioClip falseSound;
	public AudioSource sfx;
	public AudioSource bgSound;
	public void PlayClick1()
	{
		playSfx (click1);
	}

	public void PlayClick2()
	{
		playSfx (click2);
	}
	public void PlayClick3()
	{
		playSfx (click3);
	}
	public void PlayEnter()
	{
		playSfx (enterSound);
	}

	public void PlayTrue()
	{
		playSfx (trueSound);
	}

	public void PlayFalse()
	{
		playSfx (falseSound);
	}

	private void playSfx(AudioClip ac)
	{
		sfx.Stop ();
		sfx.clip = ac;
		sfx.Play ();
	}
}
